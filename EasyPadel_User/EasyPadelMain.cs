using System.Diagnostics;
using System.Net.Http;

namespace EasyPadel_User
{
    internal static class EasyPadelMain
    {
        private static readonly HttpClient HttpClient = new()
        {
            Timeout = TimeSpan.FromSeconds(2)
        };

        private static Process? serverProcess;
        private static int serverProcessId;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.ApplicationExit += (_, _) => StopServerProcess();

            if (!TryStartBackendAndWaitUntilReady())
            {
                MessageBox.Show("No s'ha pogut conectar amb la base de dades. Si us plau, reinicii la aplicació.");
                StopServerProcess();
                return;
            }

            Application.Run(new EasyPadel());
        }

        private static bool TryStartBackendAndWaitUntilReady()
        {
            using var loadingDialog = new LoadingDialogForm("Conectant a la base de dades...");
            loadingDialog.Show();
            loadingDialog.Refresh();

            try
            {
                bool started = Task.Run(StartBackendProcess).GetAwaiter().GetResult();
                if (!started)
                {
                    return false;
                }

                Stopwatch timeout = Stopwatch.StartNew();
                while (timeout.Elapsed < TimeSpan.FromSeconds(30))
                {
                    Application.DoEvents();

                    if (IsServerReady())
                    {
                        return true;
                    }

                    Thread.Sleep(500);
                }

                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (!loadingDialog.IsDisposed)
                {
                    loadingDialog.Close();
                }
            }
        }

        private static bool StartBackendProcess()
        {
            if (!TryGetBackendJarPath(out string jarPath))
            {
                return false;
            }

            var startInfo = new ProcessStartInfo
            {
                FileName = "java",
                Arguments = $"-jar \"{jarPath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Path.GetDirectoryName(jarPath) ?? string.Empty
            };

            serverProcess = Process.Start(startInfo);
            if (serverProcess is null)
            {
                return false;
            }

            serverProcessId = serverProcess.Id;
            return serverProcessId > 0;
        }

        private static bool IsServerReady()
        {
            try
            {
                using HttpResponseMessage response = HttpClient.GetAsync("http://localhost:8080/status").GetAwaiter().GetResult();
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        private static bool TryGetBackendJarPath(out string jarPath)
        {
            DirectoryInfo? currentDirectory = new(AppContext.BaseDirectory);

            while (currentDirectory is not null)
            {
                string serverPath = Path.Combine(currentDirectory.FullName, "server");
                if (Directory.Exists(serverPath))
                {
                    string? jar = Directory
                        .GetFiles(serverPath, "easypadel-backend-*.jar")
                        .OrderByDescending(file => file)
                        .FirstOrDefault();

                    if (!string.IsNullOrWhiteSpace(jar))
                    {
                        jarPath = jar;
                        return true;
                    }
                }

                currentDirectory = currentDirectory.Parent;
            }

            jarPath = string.Empty;
            return false;
        }

        private static void StopServerProcess()
        {
            try
            {
                if (serverProcess is not null && !serverProcess.HasExited)
                {
                    serverProcess.Kill(true);
                    serverProcess.WaitForExit(3000);
                }
            }
            catch
            {
            }
        }

        private sealed class LoadingDialogForm : Form
        {
            public LoadingDialogForm(string message)
            {
                FormBorderStyle = FormBorderStyle.FixedDialog;
                ControlBox = false;
                StartPosition = FormStartPosition.CenterScreen;
                ShowInTaskbar = false;
                TopMost = true;
                MinimizeBox = false;
                MaximizeBox = false;
                ClientSize = new Size(360, 90);

                var label = new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = message
                };

                Controls.Add(label);
            }
        }
    }
}
