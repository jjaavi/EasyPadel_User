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
            panel2 = new Panel();
            lblPrincipal = new Label();
            panelReserves = new Panel();
            dataGridViewReservesSoci = new DataGridView();
            btnFerReserva = new Button();
            btnMevesReserves = new Button();
            btnConfiguracio = new Button();
            btnReservesActuals = new Button();
            btnReservesAnteriors = new Button();
            btnCancelarReserva = new Button();
            panelReserves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservesSoci).BeginInit();
            SuspendLayout();
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.BackColor = Color.White;
            btnCancelarReserva.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarReserva.Location = new Point(862, 625);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(187, 34);
            btnCancelarReserva.TabIndex = 10;
            btnCancelarReserva.Text = "Cancelar reserva";
            btnCancelarReserva.UseVisualStyleBackColor = false;
            btnCancelarReserva.Click += btnCancelarReserva_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.EasyPadel_logo1;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(954, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(95, 100);
            panel2.TabIndex = 2;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrincipal.Location = new Point(429, 12);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(210, 36);
            lblPrincipal.TabIndex = 3;
            lblPrincipal.Text = "Panell de soci";
            lblPrincipal.TextAlign = ContentAlignment.TopCenter;
            lblPrincipal.Click += label1_Click;
            // 
            // panelReserves
            // 
            panelReserves.BackColor = Color.White;
            panelReserves.Controls.Add(dataGridViewReservesSoci);
            panelReserves.Location = new Point(12, 157);
            panelReserves.Name = "panelReserves";
            panelReserves.Size = new Size(1037, 462);
            panelReserves.TabIndex = 4;
            // 
            // dataGridViewReservesSoci
            // 
            dataGridViewReservesSoci.BackgroundColor = Color.White;
            dataGridViewReservesSoci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservesSoci.Location = new Point(19, 15);
            dataGridViewReservesSoci.Name = "dataGridViewReservesSoci";
            dataGridViewReservesSoci.RowHeadersWidth = 62;
            dataGridViewReservesSoci.Size = new Size(998, 434);
            dataGridViewReservesSoci.TabIndex = 0;
            dataGridViewReservesSoci.CellContentClick += dataGridViewReservesSoci_CellContentClick;
            // 
            // btnFerReserva
            // 
            btnFerReserva.BackColor = Color.White;
            btnFerReserva.Location = new Point(12, 78);
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
            btnConfiguracio.Name = "btnConfiguracio";
            btnConfiguracio.Size = new Size(208, 34);
            btnConfiguracio.TabIndex = 7;
            btnConfiguracio.Text = "Configuració";
            btnConfiguracio.UseVisualStyleBackColor = true;
            // 
            // btnReservesActuals
            // 
            btnReservesActuals.Location = new Point(646, 118);
            btnReservesActuals.Name = "btnReservesActuals";
            btnReservesActuals.Size = new Size(210, 34);
            btnReservesActuals.TabIndex = 8;
            btnReservesActuals.Text = "Reserves actuals";
            btnReservesActuals.UseVisualStyleBackColor = true;
            btnReservesActuals.Click += btnReservesActuals_Click;
            // 
            // btnReservesAnteriors
            // 
            btnReservesAnteriors.Location = new Point(862, 118);
            btnReservesAnteriors.Name = "btnReservesAnteriors";
            btnReservesAnteriors.Size = new Size(187, 34);
            btnReservesAnteriors.TabIndex = 9;
            btnReservesAnteriors.Text = "Reserves anteriors";
            btnReservesAnteriors.UseVisualStyleBackColor = true;
            btnReservesAnteriors.Click += btnReservesAnteriors_Click;
            // 
            // FormUsuari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 221, 40);
            ClientSize = new Size(1061, 685);
            Controls.Add(btnCancelarReserva);
            Controls.Add(btnReservesAnteriors);
            Controls.Add(btnReservesActuals);
            Controls.Add(btnConfiguracio);
            Controls.Add(btnMevesReserves);
            Controls.Add(btnFerReserva);
            Controls.Add(panelReserves);
            Controls.Add(lblPrincipal);
            Controls.Add(panel2);
            Name = "FormUsuari";
            Text = "FormUsuari";
            Load += FormUsuari_Load;
            panelReserves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservesSoci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
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
    }
}