using ManagerFinances.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class DataControl
{
    // Metodo el cual verifica si el gmail y la contraseña se encuentra en
    // la base de datos (Retorna el ID del usuario si existe, sino manda un 0)
    public int Login(string gmail, string password)
    {
        using (var context = new FMContext())
        {
            string correo = gmail;
            string clave = password;

            var usuario = context.Usuarios.FirstOrDefault(u => u.Correo == correo && u.Clave == clave);

            if (usuario != null)
            {
                return usuario.UsuarioID;
            }
            else
            {
                return 0;
            }
        }
    }

    // Metodo el cual añade un usuario con su nombre, correo y contraseña, con su manejo de excepciones.
    public void AddUser(string name, string account, string password)
    {
        using (var context = new FMContext())
        {
            var usuario = new User
            {
                Nombre = name,
                Correo = account,
                Clave = password
            };
            if (usuario != null)
            {
                if (context.Usuarios.Any(u => u.Correo == account))
                {
                    MessageBox.Show("El correo electrónico ya está registrado.");
                    return;
                }

                context.Usuarios.Add(usuario);

                context.SaveChanges();
                MessageBox.Show("Usuario se registro correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
