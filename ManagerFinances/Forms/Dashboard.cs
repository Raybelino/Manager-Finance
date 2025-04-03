using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerFinances.Forms
{
    public partial class Dashboard: Form
    {
        private int UserID;

        // Se inicia el Dashboard y se carga el datagridview y las variables
        public Dashboard(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
            LoadDataAccount();
        }

        // Metodo que carga los datos en el datagridview
        private void LoadDataAccount()
        {
            DataControl dataControl = new DataControl();
            dvDashboard.DataSource = dataControl.DataAccountWithTransaccion(UserID);
            dvDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dvDashboard.RowCount == 0)
                return;
            dvDashboard.Columns["CuentaID"].Visible = false;
        }

        // Cuando se hace click para acceder al gestor de usuario
        private void bt_User_Click(object sender, EventArgs e)
        {
        }

        // Cuando se hace click para salir de la app
        private void bt_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando se hace click para acceder al gestor de transacciones
        private void bt_Transactions_Click(object sender, EventArgs e)
        {
        }

        // Cuando se hace click para acceder al gestor de cuentas
        private void bt_cuentas_Click(object sender, EventArgs e)
        {
        }

        // Cuando se hace click para actualizar el datagridview
        private void bt_Update_dv_Click(object sender, EventArgs e)
        {
            LoadDataAccount();
        }

        // Cuando se hace click para cerrar al seccion
        private void bt_Cerrar_Seccion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
