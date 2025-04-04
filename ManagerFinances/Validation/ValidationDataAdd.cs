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

    // Metodo que valida si el monto es diferente a 0
    public bool ValidarMonto(decimal monto)
    {
        return monto > 0;
    }

    // Metodo que valida si la descripcion y monto de la transaccion no tiene espacio y
    // si se tiene algo seleccionado en el comboBox, y se ve si el monto es un decimal
    public bool ValidarTransaccion(string tb_Descripcion, string tb_Monto, ComboBox cb_Categoria)
    {
        if (string.IsNullOrWhiteSpace(tb_Descripcion) || string.IsNullOrWhiteSpace(tb_Monto) || cb_Categoria.SelectedIndex == -1)
        {
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (decimal.TryParse(tb_Monto, out decimal numero))
        {
            return true;
        }
        else
        {
            MessageBox.Show("Por favor, introduce un número.");
            return false;
        }
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
