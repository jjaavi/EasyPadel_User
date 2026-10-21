using System.Net.Http.Json;

namespace EasyPadel_User
{
    public partial class FormUsuari : Form
    {
        private static readonly HttpClient HttpClient = new();

        public FormUsuari()
        {
            InitializeComponent();
            InicialitzarGridReserves();
            btnConfiguracio.Click += btnConfiguracio_Click;
            dataGridViewReservesSoci.SelectionChanged += dataGridViewReservesSoci_SelectionChanged;
            MarcarMenuActiu(btnMevesReserves);
            MarcarSubmenuReservesActiu(btnReservesActuals);
            MostrarOpcionsReserves(true);
            ActualitzarEstatBotoCancelarReserva();
        }

        private void InicialitzarGridReserves()
        {
            dataGridViewReservesSoci.Dock = DockStyle.Fill;
            dataGridViewReservesSoci.ReadOnly = true;
            dataGridViewReservesSoci.AllowUserToAddRows = false;
            dataGridViewReservesSoci.AllowUserToDeleteRows = false;
            dataGridViewReservesSoci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservesSoci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservesSoci.MultiSelect = false;
        }

        private void MarcarMenuActiu(Button botoActiu)
        {
            Button[] botonsMenu = [btnFerReserva, btnMevesReserves, btnConfiguracio];

            foreach (Button boto in botonsMenu)
            {
                boto.UseVisualStyleBackColor = false;
                boto.BackColor = boto == botoActiu ? Color.White : SystemColors.ControlLight;
            }
        }

        private void MarcarSubmenuReservesActiu(Button botoActiu)
        {
            Button[] botonsSubmenu = [btnReservesActuals, btnReservesAnteriors, btnCancelarReserva];

            foreach (Button boto in botonsSubmenu)
            {
                boto.UseVisualStyleBackColor = false;
                boto.BackColor = boto == botoActiu ? Color.White : SystemColors.ControlLight;
            }
        }

        private void MostrarOpcionsReserves(bool visible)
        {
            btnReservesActuals.Visible = visible;
            btnReservesAnteriors.Visible = visible;
            btnCancelarReserva.Visible = visible;
            dataGridViewReservesSoci.Visible = visible;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void btnMevesReserves_Click(object sender, EventArgs e)
        {
            MarcarMenuActiu(btnMevesReserves);
            MarcarSubmenuReservesActiu(btnReservesActuals);
            MostrarOpcionsReserves(true);
            await CarregarReservesActualsAsync();
        }

        private async void FormUsuari_Load(object sender, EventArgs e)
        {
            MostrarOpcionsReserves(true);
            MarcarSubmenuReservesActiu(btnReservesActuals);
            await CarregarReservesActualsAsync();
        }

        private async void btnReservesActuals_Click(object? sender, EventArgs e)
        {
            MarcarSubmenuReservesActiu(btnReservesActuals);
            await CarregarReservesActualsAsync();
        }

        private async void btnReservesAnteriors_Click(object? sender, EventArgs e)
        {
            MarcarSubmenuReservesActiu(btnReservesAnteriors);
            await CarregarReservesAnteriorsAsync();
        }

        private async Task CarregarReservesActualsAsync()
        {
            await CarregarReservesDataGrid($"http://localhost:8080/api/reserves/usuari/{SessionContext.UsuariId}/posteriors");
        }

        private async Task CarregarReservesAnteriorsAsync()
        {
            string dataActual = DateTime.Today.ToString("yyyy-MM-dd");
            await CarregarReservesDataGrid($"http://localhost:8080/api/reserves/usuari/{SessionContext.UsuariId}/anteriors?data={dataActual}");
        }

        private async Task CarregarReservesDataGrid(string endpoint)
        {
            if (SessionContext.UsuariId <= 0)
            {
                MessageBox.Show("No s'ha pogut identificar l'usuari.");
                return;
            }

            try
            {
                List<ReservaResponseDto> reserves = await HttpClient.GetFromJsonAsync<List<ReservaResponseDto>>(endpoint)
                    ?? new List<ReservaResponseDto>();

                dataGridViewReservesSoci.DataSource = reserves
                    .Select(r => new
                    {
                        Id = r.Id,
                        Data = r.Data,
                        Torn = r.Torn,
                        Pista = r.PistaNom
                    })
                    .ToList();

                ActualitzarEstatBotoCancelarReserva();
            }
            catch
            {
                MessageBox.Show("No s'han pogut carregar les reserves de l'usuari.");
            }
        }

        private void btnFerReserva_Click(object sender, EventArgs e)
        {
            MarcarMenuActiu(btnFerReserva);
            MostrarOpcionsReserves(false);
        }

        private void btnConfiguracio_Click(object? sender, EventArgs e)
        {
            MarcarMenuActiu(btnConfiguracio);
            MostrarOpcionsReserves(false);
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            MarcarSubmenuReservesActiu(btnCancelarReserva);
        }

        private void dataGridViewReservesSoci_SelectionChanged(object? sender, EventArgs e)
        {
            ActualitzarEstatBotoCancelarReserva();
        }

        private void ActualitzarEstatBotoCancelarReserva()
        {
            btnCancelarReserva.Enabled = dataGridViewReservesSoci.SelectedRows.Count > 0;
        }

        private sealed record ReservaResponseDto(int Id, int UsuariId, string UsuariNom, string UsuariCognom, int PistaId, string PistaNom, string Data, int Torn);
    }
}
