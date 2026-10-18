namespace EasyPadel_User
{
    public partial class EasyPadel : Form
    {
        private const string PlaceholderUsuari = "Correu electrònic";
        private const string PlaceholderPassword = "Contrasenya";

        public EasyPadel()
        {
            InitializeComponent();
            InicialitzarPlaceholders();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void InicialitzarPlaceholders()
        {
            MostrarPlaceholder(textBoxUsuari, PlaceholderUsuari, false);
            MostrarPlaceholder(textBoxPassword, PlaceholderPassword, true);

            textBoxUsuari.Enter += textBoxUsuari_Enter;
            textBoxUsuari.Leave += textBoxUsuari_Leave;
            textBoxPassword.Enter += textBoxPassword_Enter;
            textBoxPassword.Leave += textBoxPassword_Leave;
        }

        private void textBoxUsuari_Enter(object? sender, EventArgs e)
        {
            TreurePlaceholder(textBoxUsuari, PlaceholderUsuari, false);
        }

        private void textBoxUsuari_Leave(object? sender, EventArgs e)
        {
            RestaurarPlaceholder(textBoxUsuari, PlaceholderUsuari, false);
        }

        private void textBoxPassword_Enter(object? sender, EventArgs e)
        {
            TreurePlaceholder(textBoxPassword, PlaceholderPassword, true);
        }

        private void textBoxPassword_Leave(object? sender, EventArgs e)
        {
            RestaurarPlaceholder(textBoxPassword, PlaceholderPassword, true);
        }

        private static void MostrarPlaceholder(TextBox textBox, string placeholder, bool esPassword)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.DarkGray;
            textBox.UseSystemPasswordChar = false;
        }

        private static void TreurePlaceholder(TextBox textBox, string placeholder, bool esPassword)
        {
            if (textBox.ForeColor == Color.DarkGray && textBox.Text == placeholder)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = SystemColors.WindowText;
                textBox.UseSystemPasswordChar = esPassword;
            }
        }

        private static void RestaurarPlaceholder
(TextBox textBox, string placeholder, bool esPassword)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MostrarPlaceholder(textBox, placeholder, esPassword);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            bool mailBuit = string.IsNullOrWhiteSpace(textBoxUsuari.Text) ||
                            (textBoxUsuari.ForeColor == Color.DarkGray && textBoxUsuari.Text == PlaceholderUsuari);

            bool passwordBuit = string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                                (textBoxPassword.ForeColor == Color.DarkGray && textBoxPassword.Text == PlaceholderPassword);

            if (mailBuit || passwordBuit)
            {
                MessageBox.Show("S'han d'emplenar els camps mail i password.");
            }
        }
    }
}