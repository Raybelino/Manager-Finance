using System.Drawing;
using System.Windows.Forms;
public class PlaceholderTextBox
{
    // Metodo que permite al usuario esconder o mostrar la contraseña cuando esta escribiendo
    // Tambien oculta el texto que estaba escrito para que funcione como Placeholder
    public void EnterTextBox(TextBox textBox, string text, bool isPassword)
    {
        if (textBox.Text == text)
        {
            textBox.Text = "";
            textBox.ForeColor = SystemColors.WindowText;

            if (isPassword == true)
            {
                textBox.PasswordChar = '*';
            }
            else
            {
                textBox.PasswordChar = '\0';
            }
        }
        else
        {
        }
    }

    // Metodo que deja el texto como el usuario habia puesto, en caso de estar vacio se pondra el Placeholder default
    public void leaveTextBox(TextBox textBox, string text, bool isPassword)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            textBox.Text = text;
            textBox.ForeColor = Color.Gray;

            if (textBox.Text != text &&isPassword == true)
            {
                textBox.PasswordChar = '*';
            }
            else
            {
                textBox.PasswordChar = '\0';
            }
        }
    }
}
