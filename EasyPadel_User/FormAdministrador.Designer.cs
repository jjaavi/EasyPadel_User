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
            panelLogo = new Panel();
            lblPrincipal = new Label();
            panelReserves = new Panel();
            comboBoxFiltreTorn = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFiltreData = new TextBox();
            txtFiltrePista = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtFiltreIDUsuari = new TextBox();
            txtFiltreIDreserva = new TextBox();
            btnCercarReserva = new Button();
            dataGridReserves = new DataGridView();
            btnModificarReserva = new Button();
            btnEliminarReserva = new Button();
            panelUsuaris = new Panel();
            panelMantenimentDePistes = new Panel();
            btnReserves = new Button();
            btnUsuaris = new Button();
            btnMantenimentDePistes = new Button();
            panelReserves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReserves).BeginInit();
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
            lblPrincipal.Location = new Point(358, 12);
            lblPrincipal.Margin = new Padding(2, 0, 2, 0);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(345, 36);
            lblPrincipal.TabIndex = 3;
            lblPrincipal.Text = "Panell de administrador";
            lblPrincipal.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelReserves
            // 
            panelReserves.BackColor = Color.White;
            panelReserves.Controls.Add(comboBoxFiltreTorn);
            panelReserves.Controls.Add(label5);
            panelReserves.Controls.Add(label3);
            panelReserves.Controls.Add(label4);
            panelReserves.Controls.Add(txtFiltreData);
            panelReserves.Controls.Add(txtFiltrePista);
            panelReserves.Controls.Add(label2);
            panelReserves.Controls.Add(label1);
            panelReserves.Controls.Add(txtFiltreIDUsuari);
            panelReserves.Controls.Add(txtFiltreIDreserva);
            panelReserves.Controls.Add(btnCercarReserva);
            panelReserves.Controls.Add(dataGridReserves);
            panelReserves.Controls.Add(btnModificarReserva);
            panelReserves.Controls.Add(btnEliminarReserva);
            panelReserves.Location = new Point(12, 117);
            panelReserves.Margin = new Padding(2);
            panelReserves.Name = "panelReserves";
            panelReserves.Size = new Size(1038, 555);
            panelReserves.TabIndex = 4;
            // 
            // comboBoxFiltreTorn
            // 
            comboBoxFiltreTorn.FormattingEnabled = true;
            comboBoxFiltreTorn.Location = new Point(583, 12);
            comboBoxFiltreTorn.Name = "comboBoxFiltreTorn";
            comboBoxFiltreTorn.Size = new Size(150, 33);
            comboBoxFiltreTorn.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 15);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 13;
            label5.Text = "Torn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 52);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 11;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 15);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 10;
            label4.Text = "Pista:";
            // 
            // txtFiltreData
            // 
            txtFiltreData.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreData.Location = new Point(364, 52);
            txtFiltreData.Name = "txtFiltreData";
            txtFiltreData.Size = new Size(150, 31);
            txtFiltreData.TabIndex = 9;
            // 
            // txtFiltrePista
            // 
            txtFiltrePista.BorderStyle = BorderStyle.FixedSingle;
            txtFiltrePista.Location = new Point(364, 11);
            txtFiltrePista.Name = "txtFiltrePista";
            txtFiltrePista.Size = new Size(150, 31);
            txtFiltrePista.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 54);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 7;
            label2.Text = "Id d'usuari:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 6;
            label1.Text = "Id de reserva:";
            // 
            // txtFiltreIDUsuari
            // 
            txtFiltreIDUsuari.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreIDUsuari.Location = new Point(145, 52);
            txtFiltreIDUsuari.Name = "txtFiltreIDUsuari";
            txtFiltreIDUsuari.Size = new Size(150, 31);
            txtFiltreIDUsuari.TabIndex = 5;
            // 
            // txtFiltreIDreserva
            // 
            txtFiltreIDreserva.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreIDreserva.Location = new Point(145, 11);
            txtFiltreIDreserva.Name = "txtFiltreIDreserva";
            txtFiltreIDreserva.Size = new Size(150, 31);
            txtFiltreIDreserva.TabIndex = 4;
            // 
            // btnCercarReserva
            // 
            btnCercarReserva.Location = new Point(866, 12);
            btnCercarReserva.Name = "btnCercarReserva";
            btnCercarReserva.Size = new Size(155, 34);
            btnCercarReserva.TabIndex = 3;
            btnCercarReserva.Text = "Cercar";
            btnCercarReserva.UseVisualStyleBackColor = true;
            btnCercarReserva.Click += btnCercarReserva_Click;
            // 
            // dataGridReserves
            // 
            dataGridReserves.AllowUserToAddRows = false;
            dataGridReserves.AllowUserToDeleteRows = false;
            dataGridReserves.AllowUserToOrderColumns = true;
            dataGridReserves.BackgroundColor = SystemColors.Control;
            dataGridReserves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReserves.Location = new Point(14, 89);
            dataGridReserves.MultiSelect = false;
            dataGridReserves.Name = "dataGridReserves";
            dataGridReserves.ReadOnly = true;
            dataGridReserves.RowHeadersWidth = 62;
            dataGridReserves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridReserves.Size = new Size(1007, 411);
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
            btnModificarReserva.Click += btnModificarReserva_Click;
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
            // panelUsuaris
            // 
            panelUsuaris.Location = new Point(12, 117);
            panelUsuaris.Name = "panelUsuaris";
            panelUsuaris.Size = new Size(1038, 555);
            panelUsuaris.TabIndex = 4;
            // 
            // panelMantenimentDePistes
            // 
            panelMantenimentDePistes.Location = new Point(12, 117);
            panelMantenimentDePistes.Name = "panelMantenimentDePistes";
            panelMantenimentDePistes.Size = new Size(1038, 555);
            panelMantenimentDePistes.TabIndex = 5;
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
            btnReserves.Click += btnReserves_Click;
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
            btnUsuaris.Click += btnUsuaris_Click;
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
            btnMantenimentDePistes.Click += btnMantenimentDePistes_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Silver;
            ClientSize = new Size(1061, 685);
            Controls.Add(panelLogo);
            Controls.Add(btnMantenimentDePistes);
            Controls.Add(btnUsuaris);
            Controls.Add(btnReserves);
            Controls.Add(panelReserves);
            Controls.Add(lblPrincipal);
            Controls.Add(panelUsuaris);
            Controls.Add(panelMantenimentDePistes);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormAdministrador";
            Text = "Easy Padel - Panell d'administrador";
            Load += FormAdministrador_Load;
            panelReserves.ResumeLayout(false);
            panelReserves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReserves).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogo;
        private Label lblPrincipal;
        private Panel panelReserves;
        private Button btnReserves;
        private Button btnUsuaris;
        private Button btnMantenimentDePistes;
        private Button btnModificarReserva;
        private Button btnEliminarReserva;
        private DataGridView dataGridReserves;
        private Panel panelUsuaris;
        private Panel panelMantenimentDePistes;
        private Button btnCercarReserva;
        private Label label2;
        private Label label1;
        private TextBox txtFiltreIDUsuari;
        private TextBox txtFiltreIDreserva;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtFiltreData;
        private TextBox txtFiltrePista;
        private ComboBox comboBoxFiltreTorn;
    }
}