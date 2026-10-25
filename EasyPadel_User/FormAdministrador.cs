using System;
using System.Globalization;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using System.Windows.Forms;

namespace EasyPadel_User
{
    public partial class FormAdministrador : Form
    {
        private static readonly HttpClient HttpClient = new();

        public FormAdministrador()
        {
            InitializeComponent();
            btnReserves.Click += btnReserves_Click;
            btnUsuaris.Click += btnUsuaris_Click;
            btnMantenimentDePistes.Click += btnMantenimentDePistes_Click;
            btnCercarReserva.Click += btnCercarReserva_Click;
        }

        private void MarcarMenuActiuAdministrador(Button botoActiu)
        {
            Button[] botonsMenu = [btnReserves, btnUsuaris, btnMantenimentDePistes];

            foreach (Button boto in botonsMenu)
            {
                boto.UseVisualStyleBackColor = false;
                boto.BackColor = boto == botoActiu ? Color.White : SystemColors.ControlLight;
            }
        }

        private async Task MostrarPanelActiu(Panel panelVisible)
        {
            panelReserves.Visible = panelVisible == panelReserves;
            panelUsuaris.Visible = panelVisible == panelUsuaris;
            panelMantenimentDePistes.Visible = panelVisible == panelMantenimentDePistes;

            if (panelReserves.Visible)
            {
                await InicialitzarPanellReservesAsync();
            }
        }

        private async void btnReserves_Click(object? sender, EventArgs e)
        {
            MarcarMenuActiuAdministrador(btnReserves);
            await MostrarPanelActiu(panelReserves);
        }

        private async void btnUsuaris_Click(object? sender, EventArgs e)
        {
            MarcarMenuActiuAdministrador(btnUsuaris);
            await MostrarPanelActiu(panelUsuaris);
        }

        private async void btnMantenimentDePistes_Click(object? sender, EventArgs e)
        {
            MarcarMenuActiuAdministrador(btnMantenimentDePistes);
            await MostrarPanelActiu(panelMantenimentDePistes);
        }

        private async Task InicialitzarPanellReservesAsync()
        {
            btnModificarReserva.Enabled = false;
            btnEliminarReserva.Enabled = false;

            if (comboBoxFiltreTorn.Items.Count == 0)
            {
                comboBoxFiltreTorn.Items.AddRange(
                [
                    string.Empty,
                    "08h-10h",
                    "10h-12h",
                    "12h-14h",
                    "14h-16h",
                    "16h-18h",
                    "18h-20h",
                    "20h-22h"
                ]);

                comboBoxFiltreTorn.SelectedIndex = 0;
            }

            await CarregarProperes20ReservesAsync();
        }

        private async Task CarregarProperes20ReservesAsync()
        {
            string dateToday = DateTime.Today.ToString("yyyy-MM-dd");
            string endpoint = $"http://localhost:8080/api/reserves/properes?data={Uri.EscapeDataString(dateToday)}";

            try
            {
                List<ReservaResponseDto> reserves = await HttpClient.GetFromJsonAsync<List<ReservaResponseDto>>(endpoint)
                    ?? [];
                ActualitzarGridReserves(reserves);
            }
            catch
            {
                MessageBox.Show("No s'han pogut carregar les reserves.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCercarReserva_Click(object? sender, EventArgs e)
        {   
            if (!validarInt(txtFiltreIDreserva.Text, out int? reservaId)
                || !validarInt(txtFiltreIDUsuari.Text, out int? usuariId)
                || !validarInt(txtFiltrePista.Text, out int? pistaId)){
                MessageBox.Show("Els camps Id reserva, Id usuari i Pista han de ser numèrics.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!validarData(txtFiltreData.Text, out string? data))
            {
                MessageBox.Show("El format de data no és vàlid. Ha de ser dd-MM-yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tornText = comboBoxFiltreTorn.SelectedItem?.ToString() ?? string.Empty;
            int tornInt = getTornComboBoxIndex(tornText);
            //Si torn > 0, es posa a int, sino es posa a null
            int? torn = tornInt > 0 ? tornInt : null;

            bool senseFiltres = !reservaId.HasValue
                && !usuariId.HasValue
                && !pistaId.HasValue
                && string.IsNullOrWhiteSpace(data)
                && !torn.HasValue;

            if (senseFiltres)
            {
                await CarregarProperes20ReservesAsync();
                return;
            }

            string endpoint = GenerateEndpointCercaAdmin(reservaId, usuariId, pistaId, data, torn);

            try
            {
                List<ReservaResponseDto> reserves = await HttpClient.GetFromJsonAsync<List<ReservaResponseDto>>(endpoint)
                    ?? [];
                ActualitzarGridReserves(reserves);
            }
            catch
            {
                MessageBox.Show("No s'han pogut carregar les reserves.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool validarInt(string text, out int? value)
        {
            string net = text.Trim();
            if (string.IsNullOrWhiteSpace(net))
            {
                value = null;
                return true;
            }

            if (int.TryParse(net, out int parsed))
            {
                value = parsed;
                return true;
            }

            value = null;
            return false;
        }

        private static bool validarData(string text, out string? data)
        {
            string formatdataok = text.Trim();
            if (string.IsNullOrWhiteSpace(formatdataok))
            {
                data = null;
                return true;
            }

            if (DateTime.TryParse(formatdataok, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime dataParsed))
            {
                data = dataParsed.ToString("yyyy-MM-dd");
                return true;
            }

            data = null;
            return false;
        }

        private static string GenerateEndpointCercaAdmin(int? reservaId, int? usuariId, int? pistaId, string? data, int? torn)
        {
            List<string> stringList = [];

            if (reservaId.HasValue)
            {
                stringList.Add($"reservaId={reservaId.Value}");
            }

            if (usuariId.HasValue)
            {
                stringList.Add($"usuariId={usuariId.Value}");
            }

            if (pistaId.HasValue)
            {
                stringList.Add($"pistaId={pistaId.Value}");
            }

            if (!string.IsNullOrWhiteSpace(data))
            {
                stringList.Add($"data={Uri.EscapeDataString(data)}");
            }

            if (torn.HasValue)
            {
                stringList.Add($"torn={torn.Value}");
            }

            return $"http://localhost:8080/api/reserves/cercaAdmin?{string.Join("&", stringList)}";
        }

        private void ActualitzarGridReserves(List<ReservaResponseDto> reserves)
        {
            dataGridReserves.DataSource = reserves
                .Select(r => new
                {
                    Id = r.Id,
                    UsuariId = r.UsuariId,
                    Usuari = $"{r.UsuariNom} {r.UsuariCognom}",
                    PistaId = r.PistaId,
                    Pista = r.PistaNom,
                    Data = r.Data,
                    Torn = GetHoresTornString(r.Torn)
                })
                .ToList();
        }

        private string GetHoresTornString(int torn)
        {
            return torn switch
            {
                1 => "08h-10h",
                2 => "10h-12h",
                3 => "12h-14h",
                4 => "14h-16h",
                5 => "16h-18h",
                6 => "18h-20h",
                7 => "20h-22h",
                _ => "Sense torn"
            };
        }

        private int getTornComboBoxIndex(string torn)
        {
            switch (torn)
            {
                case "08h-10h":
                    return 1;
                case "10h-12h":
                    return 2;
                case "12h-14h":
                    return 3;
                case "14h-16h":
                    return 4;
                case "16h-18h":
                    return 5;
                case "18h-20h":
                    return 6;
                case "20h-22h":
                    return 7;
                case "":
                    return 0;
                default:
                    return -1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void FormAdministrador_Load(object sender, EventArgs e)
        {
            MarcarMenuActiuAdministrador(btnReserves);
            await MostrarPanelActiu(panelReserves);
        }

        private sealed record ReservaResponseDto(
            [property: JsonPropertyName("id")] int Id,
            [property: JsonPropertyName("usuariId")] int UsuariId,
            [property: JsonPropertyName("usuariNom")] string UsuariNom,
            [property: JsonPropertyName("usuariCognom")] string UsuariCognom,
            [property: JsonPropertyName("pistaId")] int PistaId,
            [property: JsonPropertyName("pistaNom")] string PistaNom,
            [property: JsonPropertyName("data")] string Data,
            [property: JsonPropertyName("torn")] int Torn);
    }
}
