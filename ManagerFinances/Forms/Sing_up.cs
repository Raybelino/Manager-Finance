using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagerFinances.Forms
{
    public partial class Sing_up: Form
    {
        // Se inicia el Sing_up y carga el datagridview
        public Sing_up()
        {
            InitializeComponent();
            LoadUser();
        }
        // Carga los datos en el dataGridView
        private void LoadUser()
        {
            using (var context = new FMContext())
            {
                dvUser.DataSource = context.Usuarios.ToList();
                dvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvUser.Columns["UsuarioID"].Visible = false;
                dvUser.Columns["Cuentas"].Visible = false;
            }
        }
        // Detalles para agregar un usuario, con sus validaciones
        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_name_add.Visible == false && tb_account_add.Visible == false && tb_password_add.Visible == false)
            {
                tb_name_add.Visible = true;
                tb_account_add.Visible = true;
                tb_password_add.Visible = true;
                bt_VisiablePassword_Add.Visible = true;

                tb_name_edit.Visible = false;
                tb_account_edit.Visible = false;
                tb_password_edit.Visible = false;
                bt_VisiablePassword_Edit.Visible = false;
                return;
            }

            ValidationDataAdd validation = new ValidationDataAdd();

            if (!validation.ValidarName(tb_name_add.Text))
            {
                MessageBox.Show("El nombre no puede ser menor a 3 caracteres");
                return;
            }

            if (!validation.ValidarAccount(tb_account_add.Text))
            {
                MessageBox.Show("El correo no tiene el @gamil.com");
                return;
            }

            if (!validation.ValidarPassword(tb_password_add.Text))
            {
                MessageBox.Show("La contraseña debe de ser mayor a 8 caracteres");
                return;
            }

            DataControl dataControl = new DataControl();
            dataControl.AddUser(tb_name_add.Text, tb_account_add.Text, tb_password_add.Text);
            LoadUser();

        }
        // Detalles para la edicion de un usuario, con sus validaciones
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (dvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro para su edicion");
                return;
            }
            if (tb_name_edit.Visible == false && tb_account_edit.Visible == false && tb_password_edit.Visible == false)
            {
                tb_name_add.Visible = false;
                tb_account_add.Visible = false;
                tb_password_add.Visible = false;
                bt_VisiablePassword_Add.Visible = false;

                tb_name_edit.Visible = true;
                tb_account_edit.Visible = true;
                tb_password_edit.Visible = true;
                bt_VisiablePassword_Edit.Visible = true;

                tb_name_edit.Text = dvUser.SelectedRows[0].Cells[1].Value.ToString();
                tb_account_edit.Text = dvUser.SelectedRows[0].Cells[2].Value.ToString();
                tb_password_edit.Text = dvUser.SelectedRows[0].Cells[3].Value.ToString();
                return;
            }

            ValidationDataAdd validation = new ValidationDataAdd();

            if (!validation.ValidarName(tb_name_edit.Text))
            {
                MessageBox.Show("El nombre no puede ser menor a 3 caracteres");
                return;
            }

            if (!validation.ValidarAccount(tb_account_edit.Text))
            {
                MessageBox.Show("El correo no tiene el @gamil.com");
                return;
            }

            if (!validation.ValidarPassword(tb_password_edit.Text))
            {
                MessageBox.Show("La contraseña debe de ser mayor a 8 caracteres");
                return;
            }

            DataControl dataControl = new DataControl();
            dataControl.EditUser(Convert.ToInt32(dvUser.SelectedRows[0].Cells[0].Value), tb_name_edit.Text, tb_account_edit.Text, tb_password_edit.Text);
            LoadUser();

        }
        // Detalles para la eliminacion de un usuario
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro para su eliminacion");
                return;
            }

            tb_name_add.Visible = false;
            tb_account_add.Visible = false;
            tb_password_add.Visible = false;
            bt_VisiablePassword_Add.Visible = false;

            tb_name_edit.Visible = false;
            tb_account_edit.Visible = false;
            tb_password_edit.Visible = false;
            bt_VisiablePassword_Edit.Visible = false;

            var result = MessageBox.Show("¿Deseas borrar el registro?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataControl dataControl = new DataControl();
                dataControl.DeleteUser(Convert.ToInt32(dvUser.SelectedRows[0].Cells[0].Value));
                LoadUser();
            }
            else
            {
                MessageBox.Show("El registro no fue borrado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Detalles para cada uno de los textBox, este maneja el placehorder de los textbox
        // Añadir
        private void tb_name_add_Enter(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.EnterTextBox(tb_name_add, "Nombre", false);
        }

        private void tb_name_add_Leave(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.leaveTextBox(tb_name_add, "Nombre", false);
        }

        private void tb_account_add_Enter(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.EnterTextBox(tb_account_add, "Correo", false);
        }

        private void tb_account_add_Leave(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.leaveTextBox(tb_account_add, "Correo", false);
        }

        private void tb_password_add_Enter(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.EnterTextBox(tb_password_add, "Contraseña", true);
        }

        private void tb_password_add_Leave(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.leaveTextBox(tb_password_add, "Contraseña", true);
        }

        // Editar
        private void tb_name_edit_Enter(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.EnterTextBox(tb_name_edit, "Nombre", false);
        }

        private void tb_name_edit_Leave(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.leaveTextBox(tb_name_edit, "Nombre", false);
        }

        private void tb_account_edit_Enter(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.EnterTextBox(tb_account_edit, "Correo", false);
        }

        private void tb_account_edit_Leave(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.leaveTextBox(tb_account_edit, "Correo", false);
        }

        private void tb_password_edit_Enter(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.EnterTextBox(tb_password_edit, "Contraseña", true);
        }

        private void tb_password_edit_Leave(object sender, EventArgs e)
        {
            PlaceholderTextBox textBox = new PlaceholderTextBox();
            textBox.leaveTextBox(tb_password_edit, "Contraseña", true);
        }
        // Muestra la contraseña al momento de darle click en el apartado de Añadir
        private void bt_VisiablePassword_Add_Click(object sender, EventArgs e)
        {
            if (tb_password_add.PasswordChar == '*')
            {
                tb_password_add.PasswordChar = '\0';
                return;
            }
            tb_password_add.PasswordChar = '*';
        }
        // Muestra la contraseña al momento de darle click en el apartado de Edicion
        private void bt_VisiablePassword_Edit_Click(object sender, EventArgs e)
        {
            if (tb_password_edit.PasswordChar == '*')
            {
                tb_password_edit.PasswordChar = '\0';
                return;
            }
            tb_password_edit.PasswordChar = '*';
        }

        // Al hacer click se cerrar el getor de usuario
        private void bt_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
