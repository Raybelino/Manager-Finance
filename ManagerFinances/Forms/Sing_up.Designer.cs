namespace ManagerFinances.Forms
{
    partial class Sing_up
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sing_up));
            this.dvUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tb_name_add = new System.Windows.Forms.TextBox();
            this.tb_account_add = new System.Windows.Forms.TextBox();
            this.tb_password_add = new System.Windows.Forms.TextBox();
            this.tb_password_edit = new System.Windows.Forms.TextBox();
            this.tb_account_edit = new System.Windows.Forms.TextBox();
            this.tb_name_edit = new System.Windows.Forms.TextBox();
            this.bt_Atras = new System.Windows.Forms.Button();
            this.bt_VisiablePassword_Add = new System.Windows.Forms.Button();
            this.bt_VisiablePassword_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dvUser
            // 
            this.dvUser.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvUser.Location = new System.Drawing.Point(29, 79);
            this.dvUser.MultiSelect = false;
            this.dvUser.Name = "dvUser";
            this.dvUser.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvUser.Size = new System.Drawing.Size(574, 334);
            this.dvUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestor de usuario";
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Add.FlatAppearance.BorderSize = 0;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(437, 423);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(79, 30);
            this.bt_Add.TabIndex = 2;
            this.bt_Add.Text = "Añadir";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Edit.FlatAppearance.BorderSize = 0;
            this.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.Location = new System.Drawing.Point(437, 461);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(79, 30);
            this.bt_Edit.TabIndex = 3;
            this.bt_Edit.Text = "Editar";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(524, 423);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(79, 30);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "Eliminar";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tb_name_add
            // 
            this.tb_name_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name_add.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_name_add.Location = new System.Drawing.Point(29, 424);
            this.tb_name_add.Name = "tb_name_add";
            this.tb_name_add.Size = new System.Drawing.Size(98, 27);
            this.tb_name_add.TabIndex = 5;
            this.tb_name_add.Text = "Nombre";
            this.tb_name_add.Visible = false;
            this.tb_name_add.Enter += new System.EventHandler(this.tb_name_add_Enter);
            this.tb_name_add.Leave += new System.EventHandler(this.tb_name_add_Leave);
            // 
            // tb_account_add
            // 
            this.tb_account_add.Font = new System.Drawing.Font("Calibri", 12F);
            this.tb_account_add.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_account_add.Location = new System.Drawing.Point(133, 424);
            this.tb_account_add.Name = "tb_account_add";
            this.tb_account_add.Size = new System.Drawing.Size(148, 27);
            this.tb_account_add.TabIndex = 6;
            this.tb_account_add.Text = "Correo";
            this.tb_account_add.Visible = false;
            this.tb_account_add.Enter += new System.EventHandler(this.tb_account_add_Enter);
            this.tb_account_add.Leave += new System.EventHandler(this.tb_account_add_Leave);
            // 
            // tb_password_add
            // 
            this.tb_password_add.Font = new System.Drawing.Font("Calibri", 12F);
            this.tb_password_add.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_password_add.Location = new System.Drawing.Point(287, 424);
            this.tb_password_add.Name = "tb_password_add";
            this.tb_password_add.Size = new System.Drawing.Size(146, 27);
            this.tb_password_add.TabIndex = 7;
            this.tb_password_add.Text = "Contraseña";
            this.tb_password_add.Visible = false;
            this.tb_password_add.Enter += new System.EventHandler(this.tb_password_add_Enter);
            this.tb_password_add.Leave += new System.EventHandler(this.tb_password_add_Leave);
            // 
            // tb_password_edit
            // 
            this.tb_password_edit.Font = new System.Drawing.Font("Calibri", 12F);
            this.tb_password_edit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_password_edit.Location = new System.Drawing.Point(287, 464);
            this.tb_password_edit.Name = "tb_password_edit";
            this.tb_password_edit.Size = new System.Drawing.Size(146, 27);
            this.tb_password_edit.TabIndex = 10;
            this.tb_password_edit.Text = "Contraseña";
            this.tb_password_edit.Visible = false;
            this.tb_password_edit.Enter += new System.EventHandler(this.tb_password_edit_Enter);
            this.tb_password_edit.Leave += new System.EventHandler(this.tb_password_edit_Leave);
            // 
            // tb_account_edit
            // 
            this.tb_account_edit.Font = new System.Drawing.Font("Calibri", 12F);
            this.tb_account_edit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_account_edit.Location = new System.Drawing.Point(133, 464);
            this.tb_account_edit.Name = "tb_account_edit";
            this.tb_account_edit.Size = new System.Drawing.Size(148, 27);
            this.tb_account_edit.TabIndex = 9;
            this.tb_account_edit.Text = "Correo";
            this.tb_account_edit.Visible = false;
            this.tb_account_edit.Enter += new System.EventHandler(this.tb_account_edit_Enter);
            this.tb_account_edit.Leave += new System.EventHandler(this.tb_account_edit_Leave);
            // 
            // tb_name_edit
            // 
            this.tb_name_edit.Font = new System.Drawing.Font("Calibri", 12F);
            this.tb_name_edit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_name_edit.Location = new System.Drawing.Point(29, 464);
            this.tb_name_edit.Name = "tb_name_edit";
            this.tb_name_edit.Size = new System.Drawing.Size(98, 27);
            this.tb_name_edit.TabIndex = 8;
            this.tb_name_edit.Text = "Nombre";
            this.tb_name_edit.Visible = false;
            this.tb_name_edit.Enter += new System.EventHandler(this.tb_name_edit_Enter);
            this.tb_name_edit.Leave += new System.EventHandler(this.tb_name_edit_Leave);
            // 
            // bt_Atras
            // 
            this.bt_Atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Atras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atras.Location = new System.Drawing.Point(12, 20);
            this.bt_Atras.Name = "bt_Atras";
            this.bt_Atras.Size = new System.Drawing.Size(48, 32);
            this.bt_Atras.TabIndex = 11;
            this.bt_Atras.Text = "Atras";
            this.bt_Atras.UseVisualStyleBackColor = false;
            this.bt_Atras.Click += new System.EventHandler(this.bt_Atras_Click);
            // 
            // bt_VisiablePassword_Add
            // 
            this.bt_VisiablePassword_Add.BackColor = System.Drawing.Color.White;
            this.bt_VisiablePassword_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_VisiablePassword_Add.ForeColor = System.Drawing.Color.White;
            this.bt_VisiablePassword_Add.Image = ((System.Drawing.Image)(resources.GetObject("bt_VisiablePassword_Add.Image")));
            this.bt_VisiablePassword_Add.Location = new System.Drawing.Point(405, 430);
            this.bt_VisiablePassword_Add.Name = "bt_VisiablePassword_Add";
            this.bt_VisiablePassword_Add.Size = new System.Drawing.Size(27, 15);
            this.bt_VisiablePassword_Add.TabIndex = 12;
            this.bt_VisiablePassword_Add.UseVisualStyleBackColor = false;
            this.bt_VisiablePassword_Add.Visible = false;
            this.bt_VisiablePassword_Add.Click += new System.EventHandler(this.bt_VisiablePassword_Add_Click);
            // 
            // bt_VisiablePassword_Edit
            // 
            this.bt_VisiablePassword_Edit.BackColor = System.Drawing.Color.White;
            this.bt_VisiablePassword_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_VisiablePassword_Edit.ForeColor = System.Drawing.Color.White;
            this.bt_VisiablePassword_Edit.Image = ((System.Drawing.Image)(resources.GetObject("bt_VisiablePassword_Edit.Image")));
            this.bt_VisiablePassword_Edit.Location = new System.Drawing.Point(404, 468);
            this.bt_VisiablePassword_Edit.Name = "bt_VisiablePassword_Edit";
            this.bt_VisiablePassword_Edit.Size = new System.Drawing.Size(27, 19);
            this.bt_VisiablePassword_Edit.TabIndex = 13;
            this.bt_VisiablePassword_Edit.UseVisualStyleBackColor = false;
            this.bt_VisiablePassword_Edit.Visible = false;
            this.bt_VisiablePassword_Edit.Click += new System.EventHandler(this.bt_VisiablePassword_Edit_Click);
            // 
            // Sing_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(627, 525);
            this.Controls.Add(this.bt_VisiablePassword_Edit);
            this.Controls.Add(this.bt_VisiablePassword_Add);
            this.Controls.Add(this.bt_Atras);
            this.Controls.Add(this.tb_password_edit);
            this.Controls.Add(this.tb_account_edit);
            this.Controls.Add(this.tb_name_edit);
            this.Controls.Add(this.tb_password_add);
            this.Controls.Add(this.tb_account_add);
            this.Controls.Add(this.tb_name_add);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Sing_up";
            this.Text = "Sing_up";
            ((System.ComponentModel.ISupportInitialize)(this.dvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox tb_name_add;
        private System.Windows.Forms.TextBox tb_account_add;
        private System.Windows.Forms.TextBox tb_password_add;
        private System.Windows.Forms.TextBox tb_password_edit;
        private System.Windows.Forms.TextBox tb_account_edit;
        private System.Windows.Forms.TextBox tb_name_edit;
        private System.Windows.Forms.Button bt_Atras;
        private System.Windows.Forms.Button bt_VisiablePassword_Add;
        private System.Windows.Forms.Button bt_VisiablePassword_Edit;
    }
}