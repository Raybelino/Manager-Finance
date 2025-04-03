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

    // Metodo el cual edita los datos del usuario con el ID del usuario, nombre, correo y contraseña, con su manejo de excepciones.
    public void EditUser(int id, string name, string account, string password)
    {
        try
        {
            using (var context = new FMContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.UsuarioID == id);

                if (usuario != null)
                {
                    usuario.Nombre = name;
                    usuario.Correo = account;
                    usuario.Clave = password;

                    context.SaveChanges();
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hubo un problema en la edicion del usuario, el error es: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Metodo el cual elimina el usuario con el ID del usuario, con su manejo de excepciones.
    public void DeleteUser(int id)
    {
        using (var context = new FMContext())
        {
            var usuario = context.Usuarios.Find(id);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);

                context.SaveChanges();
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Metodo el cual trae el nombre de la cuenta, el numero de transacciones y
    // el total del monto de las transacciones, se necesita el ID del usuario
    public List<dynamic> DataAccountWithTransaccion(int UserID)
    {
        using (var context = new FMContext())
        {
            var resultado = context.Cuentas
                .Where(c => c.UsuarioID == UserID)
                .Select(c => new
                {
                    c.CuentaID,
                    NombreCuenta = c.Nombre,
                    NumeroTransacciones = c.Transacciones.Count(),
                    TotalMonto = c.Transacciones.Sum(t => (decimal?)t.Monto) ?? 0
                })
                .ToList<dynamic>();
            return resultado;
        }
    }

    // Metodo el cual añade una transaccion con el ID de la cuenta, ID de la categoria,
    // el monto y la descripcion, con su manejo de excepciones.
    public void AddTransaction(int cuentaID, int categoriaID, decimal monto, string descripcion)
    {
        using (var context = new FMContext())
        {
            var cuenta = context.Cuentas.Find(cuentaID);
            var categoria = context.Categorias.Find(categoriaID);

            if (cuenta == null)
            {
                MessageBox.Show("Error: La cuenta no existe.");
                return;
            }

            if (categoria == null)
            {
                MessageBox.Show("Error: La categoría no existe.");
                return;
            }

            var Transaccion = new Transaction
            {
                CuentaID = cuentaID,
                CategoriaID = categoriaID,
                Monto = monto,
                Fecha = DateTime.Now,
                Descripcion = descripcion
            };

            context.Transacciones.Add(Transaccion);

            cuenta.Saldo += monto;

            context.SaveChanges();

            MessageBox.Show("Transacción insertada correctamente.");
        }
    }

    // Metodo el cual añade una cuenta con el ID de la cuenta, el nombre,y el saldo, con su manejo de excepciones.
    public void AddAccount(int usuarioID, string nombre, decimal saldo)
    {
        using (var context = new FMContext())
        {
            var usuario = context.Usuarios.Find(usuarioID);

            if (usuario == null)
            {
                MessageBox.Show("Error: El usuario no existe.");
                return;
            }

            var Cuenta = new Account
            {
                UsuarioID = usuarioID,
                Nombre = nombre,
                Saldo = saldo
            };

            context.Cuentas.Add(Cuenta);
            context.SaveChanges();

            MessageBox.Show("Cuenta creada correctamente.");
        }
    }

    // Metodo el cual edita los datos de la cuenta con el ID de la cuenta, nombre y saldo, con su manejo de excepciones.
    public void EditAccount(int accountID, string Name, string Saldo)
    {
        using (var context = new FMContext())
        {
            var Account = context.Cuentas.FirstOrDefault(t => t.CuentaID == accountID);

            if (Account != null)
            {
                Account.Nombre = Name;
                Account.Saldo = decimal.Parse(Saldo);

                context.SaveChanges();
                MessageBox.Show("Transacción actualizada con éxito.");
            }
            else
            {
                MessageBox.Show("Transacción no encontrada.");
            }
        }
    }

    // Metodo el cual elimina la cuenta con el ID de la cuenta, con su manejo de excepciones.
    public void DeleteAccount(int id)
    {
        using (var context = new FMContext())
        {
            var Account = context.Cuentas.Find(id);
            if (Account != null)
            {
                context.Cuentas.Remove(Account);

                context.SaveChanges();
                MessageBox.Show("Transaccion eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transaccion no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Metodo el cual añade una categoria con el nombre y el tipo de categoria, con su manejo de excepciones.
    public void AddCategory(string nombre, char tipo)
    {
        using (var context = new FMContext())
        {
            if (tipo != 'I' && tipo != 'E')
            {
                MessageBox.Show("Error: El tipo debe ser 'I' (Ingreso) o 'E' (Egreso).");
                return;
            }

            var Categoria = new Category
            {
                Nombre = nombre,
                Tipo = tipo
            };

            context.Categorias.Add(Categoria);
            context.SaveChanges();

            MessageBox.Show($"Categoría '{nombre}' creada correctamente.");
        }
    }
}
