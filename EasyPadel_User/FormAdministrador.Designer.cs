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
            btnReserves = new Button();
            btnUsuaris = new Button();
            SuspendLayout();
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
            lblPrincipal.Location = new Point(357, 12);
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
            panelReserves.Location = new Point(12, 129);
            panelReserves.Name = "panelReserves";
            panelReserves.Size = new Size(1037, 544);
            panelReserves.TabIndex = 4;
            // 
            // btnReserves
            // 
            btnReserves.Location = new Point(12, 78);
            btnReserves.Name = "btnReserves";
            btnReserves.Size = new Size(208, 34);
            btnReserves.TabIndex = 5;
            btnReserves.Text = "Reserves";
            btnReserves.UseVisualStyleBackColor = true;
            // 
            // btnUsuaris
            // 
            btnUsuaris.Location = new Point(226, 78);
            btnUsuaris.Name = "btnUsuaris";
            btnUsuaris.Size = new Size(208, 34);
            btnUsuaris.TabIndex = 6;
            btnUsuaris.Text = "Usuaris";
            btnUsuaris.UseVisualStyleBackColor = true;
            btnUsuaris.Click += button1_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1061, 685);
            Controls.Add(btnUsuaris);
            Controls.Add(btnReserves);
            Controls.Add(panelReserves);
            Controls.Add(lblPrincipal);
            Controls.Add(panel2);
            Name = "FormAdministrador";
            Text = "FormUsuari";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblPrincipal;
        private Panel panelReserves;
        private Button btnReserves;
        private Button btnUsuaris;
    }
}