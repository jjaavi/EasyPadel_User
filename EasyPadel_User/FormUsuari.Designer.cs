namespace EasyPadel_User
{
    partial class FormUsuari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            panelLogo = new Panel();
            lblPrincipal = new Label();
            panelReserves = new Panel();
            dataGridViewReservesSoci = new DataGridView();
            btnReservesAnteriors = new Button();
            btnReservesActuals = new Button();
            panelNovaReserva = new Panel();
            btnExecutarNovaReserva = new Button();
            listTorns = new ListBox();
            listPistesDisponibles = new ListBox();
            lblNovaReserva4 = new Label();
            lblNovaReserva3 = new Label();
            monthCalendarSeleccio = new MonthCalendar();
            lblNovaReserva2 = new Label();
            lblNovaReserva1 = new Label();
            panelConfiguracioSoci = new Panel();
            btnFerReserva = new Button();
            btnMevesReserves = new Button();
            btnConfiguracio = new Button();
            btnCancelarReserva = new Button();
            panelReserves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservesSoci).BeginInit();
            panelNovaReserva.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = Properties.Resources.EasyPadel_logo1;
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Location = new Point(954, 12);
            panelLogo.Margin = new Padding(2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(95, 100);
            panelLogo.TabIndex = 2;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrincipal.Location = new Point(429, 12);
            lblPrincipal.Margin = new Padding(2, 0, 2, 0);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(210, 36);
            lblPrincipal.TabIndex = 3;
            lblPrincipal.Text = "Panell de soci";
            lblPrincipal.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelReserves
            // 
            panelReserves.BackColor = Color.White;
            panelReserves.Controls.Add(btnCancelarReserva);
            panelReserves.Controls.Add(dataGridViewReservesSoci);
            panelReserves.Controls.Add(btnReservesAnteriors);
            panelReserves.Controls.Add(btnReservesActuals);
            panelReserves.Location = new Point(12, 116);
            panelReserves.Margin = new Padding(2);
            panelReserves.Name = "panelReserves";
            panelReserves.Size = new Size(1038, 555);
            panelReserves.TabIndex = 4;
            // 
            // dataGridViewReservesSoci
            // 
            dataGridViewReservesSoci.BackgroundColor = Color.White;
            dataGridViewReservesSoci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservesSoci.Location = new Point(19, 44);
            dataGridViewReservesSoci.Margin = new Padding(2);
            dataGridViewReservesSoci.Name = "dataGridViewReservesSoci";
            dataGridViewReservesSoci.RowHeadersWidth = 62;
            dataGridViewReservesSoci.Size = new Size(998, 459);
            dataGridViewReservesSoci.TabIndex = 0;
            dataGridViewReservesSoci.CellContentClick += dataGridViewReservesSoci_CellContentClick;
            // 
            // btnReservesAnteriors
            // 
            btnReservesAnteriors.Location = new Point(829, 5);
            btnReservesAnteriors.Margin = new Padding(2);
            btnReservesAnteriors.Name = "btnReservesAnteriors";
            btnReservesAnteriors.Size = new Size(188, 34);
            btnReservesAnteriors.TabIndex = 9;
            btnReservesAnteriors.Text = "Reserves anteriors";
            btnReservesAnteriors.UseVisualStyleBackColor = true;
            btnReservesAnteriors.Click += btnReservesAnteriors_Click;
            // 
            // btnReservesActuals
            // 
            btnReservesActuals.Location = new Point(614, 6);
            btnReservesActuals.Margin = new Padding(2);
            btnReservesActuals.Name = "btnReservesActuals";
            btnReservesActuals.Size = new Size(210, 34);
            btnReservesActuals.TabIndex = 8;
            btnReservesActuals.Text = "Reserves actuals";
            btnReservesActuals.UseVisualStyleBackColor = true;
            btnReservesActuals.Click += btnReservesActuals_Click;
            // 
            // panelNovaReserva
            // 
            panelNovaReserva.BackColor = Color.White;
            panelNovaReserva.Controls.Add(btnExecutarNovaReserva);
            panelNovaReserva.Controls.Add(listTorns);
            panelNovaReserva.Controls.Add(listPistesDisponibles);
            panelNovaReserva.Controls.Add(lblNovaReserva4);
            panelNovaReserva.Controls.Add(lblNovaReserva3);
            panelNovaReserva.Controls.Add(monthCalendarSeleccio);
            panelNovaReserva.Controls.Add(lblNovaReserva2);
            panelNovaReserva.Controls.Add(lblNovaReserva1);
            panelNovaReserva.Location = new Point(12, 116);
            panelNovaReserva.Margin = new Padding(4);
            panelNovaReserva.Name = "panelNovaReserva";
            panelNovaReserva.Size = new Size(1038, 555);
            panelNovaReserva.TabIndex = 11;
            // 
            // btnExecutarNovaReserva
            // 
            btnExecutarNovaReserva.Enabled = false;
            btnExecutarNovaReserva.Location = new Point(417, 427);
            btnExecutarNovaReserva.Name = "btnExecutarNovaReserva";
            btnExecutarNovaReserva.Size = new Size(188, 34);
            btnExecutarNovaReserva.TabIndex = 7;
            btnExecutarNovaReserva.Text = "Reservar";
            btnExecutarNovaReserva.UseVisualStyleBackColor = true;
            btnExecutarNovaReserva.Click += btnExecutarNovaReserva_Click;
            // 
            // listTorns
            // 
            listTorns.FormattingEnabled = true;
            listTorns.Location = new Point(728, 78);
            listTorns.Name = "listTorns";
            listTorns.Size = new Size(188, 254);
            listTorns.TabIndex = 6;
            // 
            // listPistesDisponibles
            // 
            listPistesDisponibles.FormattingEnabled = true;
            listPistesDisponibles.Location = new Point(417, 78);
            listPistesDisponibles.Name = "listPistesDisponibles";
            listPistesDisponibles.Size = new Size(188, 254);
            listPistesDisponibles.TabIndex = 5;
            // 
            // lblNovaReserva4
            // 
            lblNovaReserva4.AutoSize = true;
            lblNovaReserva4.Location = new Point(61, 340);
            lblNovaReserva4.Name = "lblNovaReserva4";
            lblNovaReserva4.Size = new Size(252, 50);
            lblNovaReserva4.TabIndex = 4;
            lblNovaReserva4.Text = "*Les reserves nomes es poden\r\nfer amb 10 dies d'antelació.";
            // 
            // lblNovaReserva3
            // 
            lblNovaReserva3.AutoSize = true;
            lblNovaReserva3.Location = new Point(751, 44);
            lblNovaReserva3.Name = "lblNovaReserva3";
            lblNovaReserva3.Size = new Size(146, 25);
            lblNovaReserva3.TabIndex = 3;
            lblNovaReserva3.Text = "Torn disponibles:";
            // 
            // monthCalendarSeleccio
            // 
            monthCalendarSeleccio.Location = new Point(57, 78);
            monthCalendarSeleccio.Name = "monthCalendarSeleccio";
            monthCalendarSeleccio.TabIndex = 2;
            // 
            // lblNovaReserva2
            // 
            lblNovaReserva2.AutoSize = true;
            lblNovaReserva2.Location = new Point(428, 44);
            lblNovaReserva2.Name = "lblNovaReserva2";
            lblNovaReserva2.Size = new Size(147, 25);
            lblNovaReserva2.TabIndex = 1;
            lblNovaReserva2.Text = "Seleccio de pista:";
            // 
            // lblNovaReserva1
            // 
            lblNovaReserva1.AutoSize = true;
            lblNovaReserva1.Location = new Point(109, 44);
            lblNovaReserva1.Name = "lblNovaReserva1";
            lblNovaReserva1.Size = new Size(145, 25);
            lblNovaReserva1.TabIndex = 0;
            lblNovaReserva1.Text = "Selecciona el dia:";
            // 
            // panelConfiguracioSoci
            // 
            panelConfiguracioSoci.BackColor = Color.DarkOrange;
            panelConfiguracioSoci.Location = new Point(12, 116);
            panelConfiguracioSoci.Margin = new Padding(4);
            panelConfiguracioSoci.Name = "panelConfiguracioSoci";
            panelConfiguracioSoci.Size = new Size(1038, 555);
            panelConfiguracioSoci.TabIndex = 12;
            // 
            // btnFerReserva
            // 
            btnFerReserva.BackColor = Color.White;
            btnFerReserva.Location = new Point(12, 78);
            btnFerReserva.Margin = new Padding(2);
            btnFerReserva.Name = "btnFerReserva";
            btnFerReserva.Size = new Size(208, 34);
            btnFerReserva.TabIndex = 5;
            btnFerReserva.Text = "Nova reserva";
            btnFerReserva.UseVisualStyleBackColor = false;
            btnFerReserva.Click += btnFerReserva_Click;
            // 
            // btnMevesReserves
            // 
            btnMevesReserves.BackColor = Color.White;
            btnMevesReserves.Location = new Point(226, 78);
            btnMevesReserves.Margin = new Padding(2);
            btnMevesReserves.Name = "btnMevesReserves";
            btnMevesReserves.Size = new Size(208, 34);
            btnMevesReserves.TabIndex = 6;
            btnMevesReserves.Text = "Les meves reserves";
            btnMevesReserves.UseVisualStyleBackColor = false;
            btnMevesReserves.Click += btnMevesReserves_Click;
            // 
            // btnConfiguracio
            // 
            btnConfiguracio.Location = new Point(440, 78);
            btnConfiguracio.Margin = new Padding(2);
            btnConfiguracio.Name = "btnConfiguracio";
            btnConfiguracio.Size = new Size(208, 34);
            btnConfiguracio.TabIndex = 7;
            btnConfiguracio.Text = "Configuració";
            btnConfiguracio.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.BackColor = Color.White;
            btnCancelarReserva.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarReserva.Location = new Point(829, 511);
            btnCancelarReserva.Margin = new Padding(2);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(188, 34);
            btnCancelarReserva.TabIndex = 10;
            btnCancelarReserva.Text = "Cancelar reserva";
            btnCancelarReserva.UseVisualStyleBackColor = false;
            btnCancelarReserva.Click += btnCancelarReserva_Click;
            // 
            // FormUsuari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 221, 40);
            ClientSize = new Size(1061, 685);
            Controls.Add(btnConfiguracio);
            Controls.Add(btnMevesReserves);
            Controls.Add(btnFerReserva);
            Controls.Add(panelNovaReserva);
            Controls.Add(panelConfiguracioSoci);
            Controls.Add(panelLogo);
            Controls.Add(panelReserves);
            Controls.Add(lblPrincipal);
            Margin = new Padding(2);
            Name = "FormUsuari";
            Text = "FormUsuari";
            Load += FormUsuari_Load;
            panelReserves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservesSoci).EndInit();
            panelNovaReserva.ResumeLayout(false);
            panelNovaReserva.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogo;
        private Label lblPrincipal;
        private Panel panelReserves;
        private Button btnFerReserva;
        private Button btnMevesReserves;
        private Button btnConfiguracio;
        private DataGridView dataGridViewReservesSoci;

        private void dataGridViewReservesSoci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private Button btnReservesActuals;
        private Button btnReservesAnteriors;
        private Button btnCancelarReserva;
        private Panel panelNovaReserva;
        private Panel panelConfiguracioSoci;
        private Label lblNovaReserva1;
        private Label lblNovaReserva2;
        private MonthCalendar monthCalendarSeleccio;
        private Label lblNovaReserva3;
        private Label lblNovaReserva4;
        private ListBox listPistesDisponibles;
        private ListBox listTorns;
        private Button btnExecutarNovaReserva;
    }
}