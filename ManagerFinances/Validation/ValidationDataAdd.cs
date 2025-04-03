using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidationDataAdd
{
    // Metodo que valida si el textbox de nombre es diferente al placehorder,
    // si no tiene espacio y si es mayor a 3 caracteres.
    public bool ValidarName(string Name)
    {
        return Name != "Nombre" && !string.IsNullOrWhiteSpace(Name) && Name.Length >= 3;
    }

    // Metodo que valida si el correo tiene al final el @gmail.com
    public bool ValidarAccount(string Account)
    {
        string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(Account, patron);
    }

    // Metodo que valida si la contraseña tiene 8 o mas carateres y verifica si esta el placehorder
    public bool ValidarPassword(string password)
    {
        return password != "Contraseña" && password.Count() >= 8;
    }

    // Metodo que valida si el nombre y el saldo de la cuenta no esta vacio y si el saldo es decimal
    public bool ValidarAccount(string Name, string Saldo)
    {
        if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Saldo))
        {
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (decimal.TryParse(Saldo, out decimal numero))
        {
            return true;
        }
        else
        {
            MessageBox.Show("Por favor, introduce un número.");
            return false;
        }
    }
}
