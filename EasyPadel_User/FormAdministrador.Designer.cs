namespace EasyPadel_User
{
    partial class FormAdministrador
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
            dataGridReserves = new DataGridView();
            btnModificarReserva = new Button();
            btnEliminarReserva = new Button();
            btnReserves = new Button();
            btnUsuaris = new Button();
            btnMantenimentDePistes = new Button();
            btnBuscarReserva = new Button();
            panelUsuaris = new Panel();
            panel1 = new Panel();
            panelReserves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReserves).BeginInit();
            panelUsuaris.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.EasyPadel_logo1;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(954, 12);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(95, 100);
            panel2.TabIndex = 2;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrincipal.Location = new Point(358, 12);
            lblPrincipal.Margin = new Padding(2, 0, 2, 0);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(345, 36);
            lblPrincipal.TabIndex = 3;
            lblPrincipal.Text = "Panell de administrador";
            lblPrincipal.TextAlign = ContentAlignment.TopCenter;
            lblPrincipal.Click += label1_Click;
            // 
            // panelReserves
            // 
            panelReserves.BackColor = Color.White;
            panelReserves.Controls.Add(panelUsuaris);
            panelReserves.Controls.Add(btnBuscarReserva);
            panelReserves.Controls.Add(dataGridReserves);
            panelReserves.Controls.Add(btnModificarReserva);
            panelReserves.Controls.Add(btnEliminarReserva);
            panelReserves.Location = new Point(12, 117);
            panelReserves.Margin = new Padding(2);
            panelReserves.Name = "panelReserves";
            panelReserves.Size = new Size(1038, 555);
            panelReserves.TabIndex = 4;
            // 
            // dataGridReserves
            // 
            dataGridReserves.BackgroundColor = SystemColors.Control;
            dataGridReserves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReserves.Location = new Point(14, 52);
            dataGridReserves.Name = "dataGridReserves";
            dataGridReserves.RowHeadersWidth = 62;
            dataGridReserves.Size = new Size(1007, 448);
            dataGridReserves.TabIndex = 2;
            // 
            // btnModificarReserva
            // 
            btnModificarReserva.Location = new Point(705, 506);
            btnModificarReserva.Name = "btnModificarReserva";
            btnModificarReserva.Size = new Size(155, 34);
            btnModificarReserva.TabIndex = 1;
            btnModificarReserva.Text = "Modificar";
            btnModificarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEliminarReserva
            // 
            btnEliminarReserva.Location = new Point(866, 506);
            btnEliminarReserva.Name = "btnEliminarReserva";
            btnEliminarReserva.Size = new Size(155, 34);
            btnEliminarReserva.TabIndex = 0;
            btnEliminarReserva.Text = "Eliminar";
            btnEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // btnReserves
            // 
            btnReserves.Location = new Point(14, 79);
            btnReserves.Margin = new Padding(2);
            btnReserves.Name = "btnReserves";
            btnReserves.Size = new Size(258, 34);
            btnReserves.TabIndex = 5;
            btnReserves.Text = "Reserves";
            btnReserves.UseVisualStyleBackColor = true;
            // 
            // btnUsuaris
            // 
            btnUsuaris.Location = new Point(276, 79);
            btnUsuaris.Margin = new Padding(2);
            btnUsuaris.Name = "btnUsuaris";
            btnUsuaris.Size = new Size(250, 34);
            btnUsuaris.TabIndex = 6;
            btnUsuaris.Text = "Usuaris";
            btnUsuaris.UseVisualStyleBackColor = true;
            btnUsuaris.Click += button1_Click;
            // 
            // btnMantenimentDePistes
            // 
            btnMantenimentDePistes.Location = new Point(531, 79);
            btnMantenimentDePistes.Margin = new Padding(2);
            btnMantenimentDePistes.Name = "btnMantenimentDePistes";
            btnMantenimentDePistes.Size = new Size(258, 34);
            btnMantenimentDePistes.TabIndex = 7;
            btnMantenimentDePistes.Text = "Manteniment de pistes";
            btnMantenimentDePistes.UseVisualStyleBackColor = true;
            // 
            // btnBuscarReserva
            // 
            btnBuscarReserva.Location = new Point(866, 12);
            btnBuscarReserva.Name = "btnBuscarReserva";
            btnBuscarReserva.Size = new Size(155, 34);
            btnBuscarReserva.TabIndex = 3;
            btnBuscarReserva.Text = "Buscar";
            btnBuscarReserva.UseVisualStyleBackColor = true;
            // 
            // panelUsuaris
            // 
            panelUsuaris.Controls.Add(panel1);
            panelUsuaris.Location = new Point(0, 1);
            panelUsuaris.Name = "panelUsuaris";
            panelUsuaris.Size = new Size(1038, 555);
            panelUsuaris.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 555);
            panel1.TabIndex = 5;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Silver;
            ClientSize = new Size(1061, 685);
            Controls.Add(btnMantenimentDePistes);
            Controls.Add(btnUsuaris);
            Controls.Add(btnReserves);
            Controls.Add(panelReserves);
            Controls.Add(lblPrincipal);
            Controls.Add(panel2);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormAdministrador";
            Text = "Easy Padel - Panell d'administrador";
            Load += FormAdministrador_Load;
            panelReserves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridReserves).EndInit();
            panelUsuaris.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblPrincipal;
        private Panel panelReserves;
        private Button btnReserves;
        private Button btnUsuaris;
        private Button btnMantenimentDePistes;
        private Button btnModificarReserva;
        private Button btnEliminarReserva;
        private DataGridView dataGridReserves;
        private Panel panelUsuaris;
        private Panel panel1;
        private Button btnBuscarReserva;
    }
}