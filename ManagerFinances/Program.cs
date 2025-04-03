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
                // Se inicia la base de datos en sqlserver
                context.Database.Initialize(force: true);

                SetDataBase();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // En caso de que la base de datos y el usuario existe se inicia el inicio de seccion
                Application.Run(new Login());
            }
        }

        // Metodo que inserta un usuario, una cuenta, 5 categoria y una transaccion por defecto
        private static void SetDataBase()
        {
            DataControl dataControl = new DataControl();

            dataControl.AddUser("admin", "admin", "admin123");
        }
    }
}
