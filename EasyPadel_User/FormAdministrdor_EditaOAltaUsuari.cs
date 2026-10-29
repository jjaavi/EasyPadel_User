using System;
using System.Windows.Forms;

namespace EasyPadel_User
{
    public partial class FormAdministrdor_EditaOAltaUsuari : Form
    {
        private readonly bool modificar;

        public FormAdministrdor_EditaOAltaUsuari(bool modificar, string nom = "", string cognom = "", string telefon = "", string email = "", bool admin = false)
        {
            InitializeComponent();
            this.modificar = modificar;

            txtNom.Text = nom;
            txtCognom.Text = cognom;
            txtTelefon.Text = telefon;
            txtEmail.Text = email;
            if (modificar)
            {
                txtPassword.Enabled = true;
                txtPassword.Click += txtPassword_Click;
            }
            else
            {
                txtPassword.Text = "Generada automaticament";
                txtPassword.Enabled = false;
            }
            if (admin)
            {
                checkBoxAdmin.Checked = true;
            }
            else
            {
                checkBoxAdmin.Checked = false;
            }

            btnCancelar.Click += btnCancelar_Click;
            btnGuardar.Click += btnGuardar_Click;
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtPassword_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "S'esta forçant la modificació del password de l'usuari per restaurar la contraseña. Deixa en blanc el password per a NO modificar el password. Escriu qualsevol cosa per generar un password temporal nou.",
                "Informació",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
