using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ManagerFinances.Forms
{
    public partial class Transation: Form
    {
        private ValidationDataAdd validation = new ValidationDataAdd();
        private int UserID;

        // Se inicia el Transation y se carga el datagridview y las variables
        public Transation(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
            LoadTransation();
            LoadCategories();
            LoadCuentas(UserID);
        }

        // Metodo que carga los datos en el datagridview
        private void LoadTransation()
        {
            using (var context = new FMContext())
            {
                var resultado = context.Transacciones
                .Select(t => new
                {
                    ID = t.TransaccionID,
                    Cuenta = t.Cuenta.Nombre,
                    Categoria = t.Categoria.Nombre,
                    t.Monto,
                    t.Fecha,
                    t.Descripcion
                })
                .ToList();

                dvTransation.DataSource = resultado;
                dvTransation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvTransation.Columns["ID"].Visible = false;
            }
        }

        // Metodo que carga los datos en el comboBox
        private void LoadCategories()
        {
            using (var context = new FMContext())
            {
                var categorias = context.Categorias
                    .Select(c => new { c.CategoriaID, c.Nombre })
                    .ToList();

                cb_Categoria.DataSource = categorias;
                cb_Categoria.DisplayMember = "Nombre";
                cb_Categoria.ValueMember = "CategoriaID";
            }
        }

        // Metodo que carga los datos en el comboBox
        private void LoadCuentas(int usuarioID)
        {
            using (var context = new FMContext())
            {
                var cuentas = context.Cuentas
                    .Where(c => c.UsuarioID == usuarioID)
                    .Select(c => new { c.CuentaID, c.Nombre })
                    .ToList();

                cb_Cuenta.DataSource = cuentas;
                cb_Cuenta.DisplayMember = "Nombre";
                cb_Cuenta.ValueMember = "CuentaID";
            }
        }

        // Detalles para agregar una transaccion, con sus validaciones y se añade
        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (validation.ValidarTransaccion(tb_Descripcion.Text, tb_Monto.Text, cb_Categoria))
            {
                DataControl data = new DataControl();

                data.AddTransaction((int)cb_Cuenta.SelectedValue, (int)cb_Categoria.SelectedValue, Convert.ToDecimal(tb_Monto.Text), tb_Descripcion.Text);

                LoadTransation();
            }
        }

        // Detalles para editar una transaccion, con sus validaciones y se edita
        private void bt_Edit_Transaction_Click(object sender, EventArgs e)
        {
            if (dvTransation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una transaccion para su edicion");
                return;
            }
            if (tb_Descripcion.Text == "" || tb_Monto.Text == "")
            {
                string categonyName = dvTransation.SelectedRows[0].Cells[2].Value?.ToString();
                if (!string.IsNullOrEmpty(categonyName))
                {
                    using (FMContext context = new FMContext())
                    {
                        var categoria = context.Categorias.FirstOrDefault(c => c.Nombre == categonyName);
                        if (categoria != null)
                        {
                            cb_Categoria.SelectedValue = categoria.CategoriaID;
                        }
                    }
                    tb_Descripcion.Text = dvTransation.SelectedRows[0].Cells[5].Value.ToString();
                    tb_Monto.Text = dvTransation.SelectedRows[0].Cells[3].Value.ToString();
                    return;
                }
            }

            if (validation.ValidarTransaccion(tb_Descripcion.Text, tb_Monto.Text, cb_Categoria))
            {
                DataControl data = new DataControl();

                data.EditTransaction(Convert.ToInt32(dvTransation.SelectedRows[0].Cells[0].Value), tb_Descripcion.Text, tb_Monto.Text, cb_Categoria);

                LoadTransation();

                tb_Descripcion.Text = "";
                tb_Monto.Text = "";
                cb_Categoria.SelectedValue = 0;
            }
        }

        // Detalles para eliminar una transaccion, con sus validaciones y se elimina
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dvTransation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una transaccion para su eliminacion");
                return;
            }
            var result = MessageBox.Show("¿Deseas borrar la transaccion?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataControl dataControl = new DataControl();
                dataControl.DeleteTransaction(Convert.ToInt32(dvTransation.SelectedRows[0].Cells[0].Value));
                LoadTransation();
            }
            else
            {
                MessageBox.Show("La transaccion no fue borrado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
