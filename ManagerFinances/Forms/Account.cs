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
    public partial class Account: Form
    {
        private ValidationDataAdd validation = new ValidationDataAdd();
        private int UserID;

        // Se inicia el Account y se carga el datagridview y las variables
        public Account(int userID)
        {
            InitializeComponent();
            UserID = userID;
            LoadAccount();
        }

        // Metodo para la carga del datagridview 
        public void LoadAccount()
        {
            using (var context = new FMContext())
            {
                dvAccount.DataSource = context.Cuentas
                            .Where(c => c.UsuarioID == UserID)
                            .ToList();
                dvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvAccount.Columns["CuentaID"].Visible = false;
                dvAccount.Columns["UsuarioID"].Visible = false;
                dvAccount.Columns["Usuario"].Visible = false;
                dvAccount.Columns["Transacciones"].Visible = false;
            }
        }

        // Cuando se hace click para añadir una cuenta se valida y
        // se añade a la base de datos
        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (validation.ValidarAccount(tb_Name.Text, tb_Saldo.Text))
            {
                DataControl data = new DataControl();

                data.AddAccount(UserID, tb_Name.Text, Convert.ToDecimal(tb_Saldo.Text));

                LoadAccount();
            }
        }

        // Cuando se hace click para editar una cuenta se valida y
        // se edita en la base de datos
        private void bt_Edit_Account_Click(object sender, EventArgs e)
        {
            if (dvAccount.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una cuenta para su edicion");
                return;
            }
            if (tb_Name.Text == "" || tb_Saldo.Text == "")
            {
                tb_Name.Text = dvAccount.SelectedRows[0].Cells[2].Value.ToString();
                tb_Saldo.Text = dvAccount.SelectedRows[0].Cells[3].Value.ToString();
                return;
            }

            if (validation.ValidarAccount(tb_Name.Text, tb_Saldo.Text))
            {
                DataControl data = new DataControl();

                data.EditAccount(Convert.ToInt32(dvAccount.SelectedRows[0].Cells[0].Value), tb_Name.Text, tb_Saldo.Text);

                LoadAccount();

                tb_Name.Text = "";
                tb_Saldo.Text = "";
            }
        }

        // Cuando se hace click para eliminar una cuenta se valida y
        // se elimina en la base de datos
        private void bt_Delete_Account_Click(object sender, EventArgs e)
        {
            if (dvAccount.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una cuenta para su eliminacion");
                return;
            }
            var result = MessageBox.Show("¿Deseas borrar la cuenta?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataControl dataControl = new DataControl();
                dataControl.DeleteAccount(Convert.ToInt32(dvAccount.SelectedRows[0].Cells[0].Value));
                LoadAccount();
            }
            else
            {
                MessageBox.Show("La cuenta no fue borrado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
