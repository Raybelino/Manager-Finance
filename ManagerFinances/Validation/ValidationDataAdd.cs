using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidationDataAdd
{
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
}
