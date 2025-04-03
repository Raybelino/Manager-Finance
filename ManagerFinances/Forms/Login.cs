
using System;
using System.Windows.Forms;

namespace ManagerFinances
{
    public partial class Login: Form
    {
        // Se inicia el login
        public Login()
        {
            InitializeComponent();
        }

        // Cuando se de click a iniciar se comprobara si el usuario existe y
        // permitira que el usuario entre al dashboard
        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            DataControl data = new DataControl();
            if (data.Login(tb_gmail.Text, tb_Password.Text) > 0)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                return;
            }
            MessageBox.Show("Credenciales incorrectas.");
        }

        // Al momento de que se entra al textbox gmail
        private void tb_gmail_Enter(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.EnterTextBox(tb_gmail, "Correo", false);
        }

        // Al momento de que se sale del textbox gmail
        private void tb_gmail_Leave(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.leaveTextBox(tb_gmail, "Correo", false);
        }

        // Al momento de que se entra al textbox password
        private void tb_Password_Enter(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.EnterTextBox(tb_Password, "Contraseña", true);
        }

        // Al momento de que se sale del textbox password
        private void tb_Password_Leave(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.leaveTextBox(tb_Password, "Contraseña", true);
        }

        // Cuando se de click para ver la contraseña se mostrara y viceversa
        private void bt_VisiablePassword_Login_Click(object sender, EventArgs e)
        {
            if (tb_Password.PasswordChar == '*')
            {
                tb_Password.PasswordChar = '\0';
                return;
            }
            tb_Password.PasswordChar = '*';
        }
    }
}
