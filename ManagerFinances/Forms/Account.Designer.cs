namespace ManagerFinances.Forms
{
    partial class Account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_Delete_Account = new System.Windows.Forms.Button();
            this.bt_Edit_Account = new System.Windows.Forms.Button();
            this.bt_Add_Account = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Saldo = new System.Windows.Forms.TextBox();
            this.dvAccount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Delete_Account
            // 
            this.bt_Delete_Account.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Delete_Account.FlatAppearance.BorderSize = 0;
            this.bt_Delete_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete_Account.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete_Account.Location = new System.Drawing.Point(387, 362);
            this.bt_Delete_Account.Name = "bt_Delete_Account";
            this.bt_Delete_Account.Size = new System.Drawing.Size(173, 30);
            this.bt_Delete_Account.TabIndex = 23;
            this.bt_Delete_Account.Text = "Eliminar";
            this.bt_Delete_Account.UseVisualStyleBackColor = false;
            this.bt_Delete_Account.Click += new System.EventHandler(this.bt_Delete_Account_Click);
            // 
            // bt_Edit_Account
            // 
            this.bt_Edit_Account.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Edit_Account.FlatAppearance.BorderSize = 0;
            this.bt_Edit_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit_Account.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit_Account.Location = new System.Drawing.Point(481, 398);
            this.bt_Edit_Account.Name = "bt_Edit_Account";
            this.bt_Edit_Account.Size = new System.Drawing.Size(79, 30);
            this.bt_Edit_Account.TabIndex = 22;
            this.bt_Edit_Account.Text = "Editar";
            this.bt_Edit_Account.UseVisualStyleBackColor = false;
            this.bt_Edit_Account.Click += new System.EventHandler(this.bt_Edit_Account_Click);
            // 
            // bt_Add_Account
            // 
            this.bt_Add_Account.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Add_Account.FlatAppearance.BorderSize = 0;
            this.bt_Add_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add_Account.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_Account.Location = new System.Drawing.Point(387, 398);
            this.bt_Add_Account.Name = "bt_Add_Account";
            this.bt_Add_Account.Size = new System.Drawing.Size(79, 30);
            this.bt_Add_Account.TabIndex = 21;
            this.bt_Add_Account.Text = "Añadir";
            this.bt_Add_Account.UseVisualStyleBackColor = false;
            this.bt_Add_Account.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(19, 365);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(178, 27);
            this.tb_Name.TabIndex = 16;
            // 
            // tb_Saldo
            // 
            this.tb_Saldo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Saldo.Location = new System.Drawing.Point(203, 365);
            this.tb_Saldo.Name = "tb_Saldo";
            this.tb_Saldo.Size = new System.Drawing.Size(178, 27);
            this.tb_Saldo.TabIndex = 17;
            // 
            // dvAccount
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvAccount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvAccount.Location = new System.Drawing.Point(18, 57);
            this.dvAccount.MultiSelect = false;
            this.dvAccount.Name = "dvAccount";
            this.dvAccount.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvAccount.Size = new System.Drawing.Size(542, 299);
            this.dvAccount.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestor de Cuenta";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(576, 447);
            this.Controls.Add(this.bt_Delete_Account);
            this.Controls.Add(this.bt_Edit_Account);
            this.Controls.Add(this.bt_Add_Account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Saldo);
            this.Controls.Add(this.dvAccount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Account";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.dvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Delete_Account;
        private System.Windows.Forms.Button bt_Edit_Account;
        private System.Windows.Forms.Button bt_Add_Account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Saldo;
        private System.Windows.Forms.DataGridView dvAccount;
        private System.Windows.Forms.Label label1;
    }
}