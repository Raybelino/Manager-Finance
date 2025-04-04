﻿using ManagerFinances.Forms;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ManagerFinances
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Se inicializa la base de datos
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FMContext, Configuration>());

            // Se accede a la base de datos para comprobar si se creo y si un usuario ya existe
            using (var context = new FMContext())
            {
                bool dbExists = context.Database.Exists();
                bool usersExist = context.Usuarios.Any();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!dbExists || !usersExist)
                {
                    // En caso de no existir la base de datos se crea y se inicia el registro de usuario
                    // Tambien si no existe usuario se inicia el registro de usuario
                    SetDataBase();
                    Application.Run(new Sing_up());
                }
                else
                {
                    // En caso de que la base de datos y el usuario existe se inicia el inicio de seccion
                    Application.Run(new Login());
                }
            }
        }

        // Metodo que inserta un usuario, una cuenta, 5 categoria y una transaccion por defecto
        private static void SetDataBase()
        {
            DataControl dataControl = new DataControl();

            dataControl.AddUser("admin", "admin", "admin123");
            dataControl.AddAccount(1, "CuentaAdmin", 1200.00m);
            dataControl.AddCategory("Comida", 'E');
            dataControl.AddCategory("Salario", 'I');
            dataControl.AddCategory("Transporte", 'E');
            dataControl.AddCategory("Entretenimiento", 'E');
            dataControl.AddCategory("Inversión", 'I');
            dataControl.AddTransaction(1, 1, 120, "Transferencia");
        }
    }
}
