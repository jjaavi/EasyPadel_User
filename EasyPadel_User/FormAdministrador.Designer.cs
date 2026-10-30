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
            checkBoxEstat = new CheckBox();
            btnModificarUsuari = new Button();
            btnAltaUsuari = new Button();
            btnBaixaUsuari = new Button();
            comboBoxRol = new ComboBox();
            label11 = new Label();
            txtFiltreCognom = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtFiltreTelefon = new TextBox();
            txtFiltreNom = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtFiltreMail = new TextBox();
            txtFiltreUsuariUsuari = new TextBox();
            btnCercarUsuari = new Button();
            dataGridViewUsuaris = new DataGridView();
            panelMantenimentDePistes = new Panel();
            btnReserves = new Button();
            btnUsuaris = new Button();
            btnMantenimentDePistes = new Button();
            btnCanviarPasswordAdminActual = new Button();
            panelReserves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReserves).BeginInit();
            panelUsuaris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuaris).BeginInit();
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
            panelUsuaris.BackColor = Color.White;
            panelUsuaris.Controls.Add(btnCanviarPasswordAdminActual);
            panelUsuaris.Controls.Add(checkBoxEstat);
            panelUsuaris.Controls.Add(btnModificarUsuari);
            panelUsuaris.Controls.Add(btnAltaUsuari);
            panelUsuaris.Controls.Add(btnBaixaUsuari);
            panelUsuaris.Controls.Add(comboBoxRol);
            panelUsuaris.Controls.Add(label11);
            panelUsuaris.Controls.Add(txtFiltreCognom);
            panelUsuaris.Controls.Add(label6);
            panelUsuaris.Controls.Add(label7);
            panelUsuaris.Controls.Add(label8);
            panelUsuaris.Controls.Add(txtFiltreTelefon);
            panelUsuaris.Controls.Add(txtFiltreNom);
            panelUsuaris.Controls.Add(label9);
            panelUsuaris.Controls.Add(label10);
            panelUsuaris.Controls.Add(txtFiltreMail);
            panelUsuaris.Controls.Add(txtFiltreUsuariUsuari);
            panelUsuaris.Controls.Add(btnCercarUsuari);
            panelUsuaris.Controls.Add(dataGridViewUsuaris);
            panelUsuaris.Location = new Point(12, 117);
            panelUsuaris.Name = "panelUsuaris";
            panelUsuaris.Size = new Size(1038, 555);
            panelUsuaris.TabIndex = 4;
            // 
            // checkBoxEstat
            // 
            checkBoxEstat.AutoSize = true;
            checkBoxEstat.Location = new Point(705, 12);
            checkBoxEstat.Name = "checkBoxEstat";
            checkBoxEstat.Size = new Size(78, 29);
            checkBoxEstat.TabIndex = 31;
            checkBoxEstat.Text = "Actiu";
            checkBoxEstat.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuari
            // 
            btnModificarUsuari.Location = new Point(705, 494);
            btnModificarUsuari.Name = "btnModificarUsuari";
            btnModificarUsuari.Size = new Size(155, 34);
            btnModificarUsuari.TabIndex = 30;
            btnModificarUsuari.Text = "Modificar";
            btnModificarUsuari.UseVisualStyleBackColor = true;
            // 
            // btnAltaUsuari
            // 
            btnAltaUsuari.Location = new Point(373, 494);
            btnAltaUsuari.Name = "btnAltaUsuari";
            btnAltaUsuari.Size = new Size(288, 46);
            btnAltaUsuari.TabIndex = 29;
            btnAltaUsuari.Text = "ALTA D'USUARI";
            btnAltaUsuari.UseVisualStyleBackColor = true;
            // 
            // btnBaixaUsuari
            // 
            btnBaixaUsuari.Location = new Point(868, 494);
            btnBaixaUsuari.Name = "btnBaixaUsuari";
            btnBaixaUsuari.Size = new Size(155, 34);
            btnBaixaUsuari.TabIndex = 28;
            btnBaixaUsuari.Text = "Baixa d'usuari";
            btnBaixaUsuari.UseVisualStyleBackColor = true;
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(567, 46);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(124, 33);
            comboBoxRol.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(520, 51);
            label11.Name = "label11";
            label11.Size = new Size(41, 25);
            label11.TabIndex = 26;
            label11.Text = "Rol:";
            // 
            // txtFiltreCognom
            // 
            txtFiltreCognom.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreCognom.Location = new Point(567, 10);
            txtFiltreCognom.Name = "txtFiltreCognom";
            txtFiltreCognom.Size = new Size(124, 31);
            txtFiltreCognom.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 12);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 24;
            label6.Text = "Cognom:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 51);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 23;
            label7.Text = "Data:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(278, 14);
            label8.Name = "label8";
            label8.Size = new Size(56, 25);
            label8.TabIndex = 22;
            label8.Text = "Nom:";
            // 
            // txtFiltreTelefon
            // 
            txtFiltreTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreTelefon.Location = new Point(337, 51);
            txtFiltreTelefon.Name = "txtFiltreTelefon";
            txtFiltreTelefon.Size = new Size(124, 31);
            txtFiltreTelefon.TabIndex = 21;
            // 
            // txtFiltreNom
            // 
            txtFiltreNom.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreNom.Location = new Point(337, 10);
            txtFiltreNom.Name = "txtFiltreNom";
            txtFiltreNom.Size = new Size(124, 31);
            txtFiltreNom.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(81, 52);
            label9.Name = "label9";
            label9.Size = new Size(58, 25);
            label9.TabIndex = 19;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 11);
            label10.Name = "label10";
            label10.Size = new Size(99, 25);
            label10.TabIndex = 18;
            label10.Text = "Id d'usuari:";
            // 
            // txtFiltreMail
            // 
            txtFiltreMail.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreMail.Location = new Point(145, 50);
            txtFiltreMail.Name = "txtFiltreMail";
            txtFiltreMail.Size = new Size(124, 31);
            txtFiltreMail.TabIndex = 17;
            // 
            // txtFiltreUsuariUsuari
            // 
            txtFiltreUsuariUsuari.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreUsuariUsuari.Location = new Point(145, 9);
            txtFiltreUsuariUsuari.Name = "txtFiltreUsuariUsuari";
            txtFiltreUsuariUsuari.Size = new Size(124, 31);
            txtFiltreUsuariUsuari.TabIndex = 16;
            // 
            // btnCercarUsuari
            // 
            btnCercarUsuari.Location = new Point(866, 10);
            btnCercarUsuari.Name = "btnCercarUsuari";
            btnCercarUsuari.Size = new Size(155, 34);
            btnCercarUsuari.TabIndex = 15;
            btnCercarUsuari.Text = "Cercar";
            btnCercarUsuari.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuaris
            // 
            dataGridViewUsuaris.AllowUserToAddRows = false;
            dataGridViewUsuaris.AllowUserToDeleteRows = false;
            dataGridViewUsuaris.AllowUserToOrderColumns = true;
            dataGridViewUsuaris.BackgroundColor = SystemColors.Control;
            dataGridViewUsuaris.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuaris.Location = new Point(16, 89);
            dataGridViewUsuaris.MultiSelect = false;
            dataGridViewUsuaris.Name = "dataGridViewUsuaris";
            dataGridViewUsuaris.ReadOnly = true;
            dataGridViewUsuaris.RowHeadersWidth = 62;
            dataGridViewUsuaris.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuaris.Size = new Size(1007, 399);
            dataGridViewUsuaris.TabIndex = 3;
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
            // btnCanviarPasswordAdminActual
            // 
            btnCanviarPasswordAdminActual.Location = new Point(16, 494);
            btnCanviarPasswordAdminActual.Name = "btnCanviarPasswordAdminActual";
            btnCanviarPasswordAdminActual.Size = new Size(222, 34);
            btnCanviarPasswordAdminActual.TabIndex = 32;
            btnCanviarPasswordAdminActual.Text = "Canviar password admin";
            btnCanviarPasswordAdminActual.UseVisualStyleBackColor = true;
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
            Controls.Add(panelUsuaris);
            Controls.Add(panelReserves);
            Controls.Add(lblPrincipal);
            Controls.Add(panelMantenimentDePistes);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormAdministrador";
            Text = "Easy Padel - Panell d'administrador";
            Load += FormAdministrador_Load;
            panelReserves.ResumeLayout(false);
            panelReserves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReserves).EndInit();
            panelUsuaris.ResumeLayout(false);
            panelUsuaris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuaris).EndInit();
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
        private DataGridView dataGridViewUsuaris;
        private Label label11;
        private TextBox txtFiltreCognom;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtFiltreTelefon;
        private TextBox txtFiltreNom;
        private Label label9;
        private Label label10;
        private TextBox txtFiltreMail;
        private TextBox txtFiltreUsuariUsuari;
        private Button btnCercarUsuari;
        private Button btnBaixaUsuari;
        private ComboBox comboBoxRol;
        private Button btnAltaUsuari;
        private Button btnModificarUsuari;
        private CheckBox checkBoxEstat;
        private Button btnCanviarPasswordAdminActual;
    }
}