using System.Dynamic;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace EasyPadel_User
{
    public partial class FormUsuari : Form
    {
        private static readonly HttpClient HttpClient = new();
        private static int panelActiuReserves = 1;
        private bool carregantPistes;
        private async void FormUsuari_Load(object sender, EventArgs e)
        {
            MostrarPanelActiu(panelReserves);
            MarcarSubmenuReservesActiu(btnReservesActuals);
            panelActiuReserves = 1;
            await CarregarReservesActualsAsync();

            //Panel de nova reserva
            monthCalendarSeleccio.MinDate = DateTime.Today;
            monthCalendarSeleccio.MaxDate = DateTime.Today.AddDays(10);
            monthCalendarSeleccio.MaxSelectionCount = 1; // opcional, para seleccionar solo un día
        }

        public FormUsuari()
        {
            InitializeComponent();
            InicialitzarGridReserves();
            btnConfiguracio.Click += btnConfiguracio_Click;
            dataGridViewReservesSoci.SelectionChanged += dataGridViewReservesSoci_SelectionChanged;
            listPistesDisponibles.SelectedIndexChanged += listPistesDisponibles_SelectedIndexChanged;
            listTorns.SelectedIndexChanged += listTorns_SelectedIndexChanged;
            monthCalendarSeleccio.DateSelected += monthCalendarSeleccio_DateSelected;
            MarcarMenuActiuReserves(btnMevesReserves);
            MarcarSubmenuReservesActiu(btnReservesActuals);
            MostrarPanelActiu(panelReserves);
            ActualitzarEstatBotoCancelarReserva();
            ActualitzarEstatBotoExecutarNovaReserva();
        }

        private void InicialitzarGridReserves()
        {
            dataGridViewReservesSoci.Dock = DockStyle.None;
            dataGridViewReservesSoci.ReadOnly = true;
            dataGridViewReservesSoci.AllowUserToAddRows = false;
            dataGridViewReservesSoci.AllowUserToDeleteRows = false;
            dataGridViewReservesSoci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservesSoci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservesSoci.MultiSelect = false;
        }

        private void MarcarMenuActiuReserves(Button botoActiu)
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

        private void MostrarPanelActiu(Panel panelVisible)
        {
            panelReserves.Visible = panelVisible == panelReserves;
            panelNovaReserva.Visible = panelVisible == panelNovaReserva;
            panelConfiguracioSoci.Visible = panelVisible == panelConfiguracioSoci;
        }

        private async void btnMevesReserves_Click(object sender, EventArgs e)
        {
            MarcarMenuActiuReserves(btnMevesReserves);
            MarcarSubmenuReservesActiu(btnReservesActuals);
            MostrarPanelActiu(panelReserves);
            panelActiuReserves = 1;
            await CarregarReservesActualsAsync();
        }

        private async void btnReservesActuals_Click(object? sender, EventArgs e)
        {
            MarcarSubmenuReservesActiu(btnReservesActuals);
            panelActiuReserves = 1;
            await CarregarReservesActualsAsync();
        }

        private async void btnReservesAnteriors_Click(object? sender, EventArgs e)
        {
            MarcarSubmenuReservesActiu(btnReservesAnteriors);
            panelActiuReserves = 2;
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
                        Torn = getHoresTornString(r.Torn),
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

        private string getHoresTornString(int torn)
        {
            return torn switch
            {
                1 => "8h-10h",
                2 => "10h-12h",
                3 => "12h-14h",
                4 => "14h-16h",
                5 => "16h-18h",
                6 => "18h-20h",
                7 => "20h-22h",
                _ => "Sense torn"
            };
        }

        private int getTornIntFromString(string tornString)
        {
            return tornString switch
            {
                "8h-10h" => 1,
                "10h-12h" => 2,
                "12h-14h" => 3,
                "14h-16h" => 4,
                "16h-18h" => 5,
                "18h-20h" => 6,
                "20h-22h" => 7,
                _ => 0
            };
        }

        private int ObtenirHoraIniciTorn(int torn)
        {
            return torn switch
            {
                1 => 8,
                2 => 10,
                3 => 12,
                4 => 14,
                5 => 16,
                6 => 18,
                7 => 20,
                _ => 0
            };
        }

        private async void btnFerReserva_Click(object sender, EventArgs e)
        {
            MarcarMenuActiuReserves(btnFerReserva);
            MostrarPanelActiu(panelNovaReserva);
            await CarregarPistesDisponiblesAsync();
        }

        private void btnConfiguracio_Click(object? sender, EventArgs e)
        {
            MarcarMenuActiuReserves(btnConfiguracio);
            MostrarPanelActiu(panelConfiguracioSoci);
        }

        private async void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            MarcarSubmenuReservesActiu(btnCancelarReserva);

            DialogResult resultat = MessageBox.Show(
                "Segur que vols cancelar aquesta reserva?",
                "Cancelar reserva",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                int reservaId = (int)dataGridViewReservesSoci.SelectedRows[0].Cells["Id"].Value;

                try
                {
                    using HttpResponseMessage response = await HttpClient.DeleteAsync($"http://localhost:8080/api/reserves/{reservaId}");
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("No s'ha pogut cancelar la reserva.");
                    }
                }
                catch
                {
                    MessageBox.Show("No s'ha pogut cancelar la reserva.");
                }
            }

            MarcarMenuActiuReserves(btnMevesReserves);
            MarcarSubmenuReservesActiu(btnReservesActuals);
            MostrarPanelActiu(panelReserves);
            panelActiuReserves = 1;
            await CarregarReservesActualsAsync();
        }

        private async void listPistesDisponibles_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ActualitzarEstatBotoExecutarNovaReserva();

            if (carregantPistes || listPistesDisponibles.SelectedItem is not PistaDisponibleDto pistaSeleccionada)
            {
                listTorns.DataSource = null;
                listTorns.Items.Clear();
                ActualitzarEstatBotoExecutarNovaReserva();
                return;
            }

            await CarregarDisponibilitatTornsAsync(pistaSeleccionada.Id);
        }

        private void listTorns_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listTorns.SelectedItem is TornListItem torn && !torn.Disponible)
            {
                listTorns.ClearSelected();
            }

            ActualitzarEstatBotoExecutarNovaReserva();
        }

        private void monthCalendarSeleccio_DateSelected(object? sender, DateRangeEventArgs e)
        {
            ReiniciarSeleccioNovaReserva();
            ActualitzarEstatBotoExecutarNovaReserva();
        }

        private async Task CarregarPistesDisponiblesAsync()
        {
            try
            {
                carregantPistes = true;

                List<PistaDisponibleDto> pistes = await HttpClient.GetFromJsonAsync<List<PistaDisponibleDto>>("http://localhost:8080/api/pistes/actives")
                    ?? new List<PistaDisponibleDto>();

                listPistesDisponibles.DataSource = pistes;
                listPistesDisponibles.DisplayMember = nameof(PistaDisponibleDto.Nom);
                listPistesDisponibles.ValueMember = nameof(PistaDisponibleDto.Id);
                listPistesDisponibles.ClearSelected();

                listTorns.DataSource = null;
                listTorns.Items.Clear();
                listTorns.ClearSelected();
                ActualitzarEstatBotoExecutarNovaReserva();
            }
            catch
            {
                MessageBox.Show("No s'han pogut carregar les pistes disponibles.");
            }
            finally
            {
                carregantPistes = false;
            }
        }

        private async Task CarregarDisponibilitatTornsAsync(int pistaId)
        {
            try
            {
                string dataSeleccionada = monthCalendarSeleccio.SelectionStart.ToString("yyyy-MM-dd");
                DisponibilitatPistaResponseDto? resposta = await HttpClient.GetFromJsonAsync<DisponibilitatPistaResponseDto>(
                    $"http://localhost:8080/api/reserves/disponibilitat/{pistaId}?data={dataSeleccionada}");

                DateTime dataSeleccionadaDate = monthCalendarSeleccio.SelectionStart.Date;
                DateTime now = DateTime.Now;

                List<TornListItem> torns = resposta?.Torns
                    .Where(t => dataSeleccionadaDate != DateTime.Today || ObtenirHoraIniciTorn(t.Torn) > now.Hour)
                    .Select(t => new TornListItem(t.Torn, t.Disponible, t.Disponible
                        ? getHoresTornString(t.Torn)
                        : $"{getHoresTornString(t.Torn)} - No disponible"))
                    .ToList() ?? new List<TornListItem>();

                listTorns.DataSource = torns;
                listTorns.DisplayMember = nameof(TornListItem.Text);
                listTorns.ValueMember = nameof(TornListItem.Torn);
                listTorns.ClearSelected();
                ActualitzarEstatBotoExecutarNovaReserva();
            }
            catch
            {
                MessageBox.Show("No s'han pogut carregar els torns disponibles.");
            }
        }

        private void ReiniciarSeleccioNovaReserva()
        {
            listPistesDisponibles.ClearSelected();
            listTorns.DataSource = null;
            listTorns.Items.Clear();
            listTorns.ClearSelected();
            ActualitzarEstatBotoExecutarNovaReserva();
        }

        private void dataGridViewReservesSoci_SelectionChanged(object? sender, EventArgs e)
        {
            ActualitzarEstatBotoCancelarReserva();
        }

        private void ActualitzarEstatBotoCancelarReserva()
        {
            if (dataGridViewReservesSoci.SelectedRows.Count > 0 && panelActiuReserves == 1)
            {
                btnCancelarReserva.Enabled = true;
            }
            else
            {
                btnCancelarReserva.Enabled = false;
            }
        }

        private void ActualitzarEstatBotoExecutarNovaReserva()
        {
            bool dataSeleccionada = monthCalendarSeleccio.SelectionStart >= monthCalendarSeleccio.MinDate
                && monthCalendarSeleccio.SelectionStart <= monthCalendarSeleccio.MaxDate;
            bool pistaSeleccionada = listPistesDisponibles.SelectedItem is PistaDisponibleDto;
            bool tornDisponibleSeleccionat = listTorns.SelectedItem is TornListItem torn && torn.Disponible;

            if (dataSeleccionada && pistaSeleccionada && tornDisponibleSeleccionat)
            {
                btnExecutarNovaReserva.Enabled = true;
            }
            else
            {
                btnExecutarNovaReserva.Enabled = false;
            }
        }

        private async void btnExecutarNovaReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (listTorns.SelectedItem is not TornListItem tornSeleccionat ||
                    listPistesDisponibles.SelectedItem is not PistaDisponibleDto pistaSeleccionada)
                {
                    return;
                }

                DateTime dataSeleccio = monthCalendarSeleccio.SelectionStart.Date;
                string missatgeConfirmacio = $"Vols reservar el torn {tornSeleccionat.Text} per la pista {pistaSeleccionada.Nom} el dia {dataSeleccio:yyyy-MM-dd}?";

                DialogResult resultat = MessageBox.Show(
                    missatgeConfirmacio,
                    "Confirmació reserva",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultat != DialogResult.Yes)
                {
                    return;
                }

                var reservaRequest = new ReservaCreateRequestDto(
                    SessionContext.UsuariId,
                    pistaSeleccionada.Id,
                    dataSeleccio.ToString("yyyy-MM-dd"),
                    tornSeleccionat.Torn);

                using HttpResponseMessage response = await HttpClient.PostAsJsonAsync("http://localhost:8080/api/reserves", reservaRequest);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Reserva feta correctament.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CarregarDisponibilitatTornsAsync(pistaSeleccionada.Id);
                    ActualitzarEstatBotoExecutarNovaReserva();
                }
                else
                {
                    MessageBox.Show("Reserva no realitzada. Si us plau, torna a intentar-ho.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Reserva no realitzada. Si us plau, torna a intentar-ho.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private sealed record ReservaResponseDto(int Id, int UsuariId, string UsuariNom, string UsuariCognom, int PistaId, string PistaNom, string Data, int Torn);

        private sealed record PistaDisponibleDto(int Id, string Nom);

        private sealed record DisponibilitatPistaResponseDto(int PistaId, string PistaNom, string Data, List<TornDisponibilitatDto> Torns);

        private sealed record TornDisponibilitatDto(int Torn, bool Disponible);

        private sealed record ReservaCreateRequestDto(
            [property: JsonPropertyName("usuariId")] int UsuariId,
            [property: JsonPropertyName("pistaId")] int PistaId,
            [property: JsonPropertyName("data")] string Data,
            [property: JsonPropertyName("torn")] int Torn);

        private sealed record TornListItem(int Torn, bool Disponible, string Text)
        {
            public override string ToString() => Text;
        }
    }
}
