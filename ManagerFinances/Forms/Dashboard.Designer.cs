namespace ManagerFinances.Forms
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Salir = new System.Windows.Forms.Button();
            this.bt_Cerrar_Seccion = new System.Windows.Forms.Button();
            this.bt_User = new System.Windows.Forms.Button();
            this.bt_Transactions = new System.Windows.Forms.Button();
            this.bt_cuentas = new System.Windows.Forms.Button();
            this.dvDashboard = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Update_dv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_Salir);
            this.panel1.Controls.Add(this.bt_Cerrar_Seccion);
            this.panel1.Controls.Add(this.bt_User);
            this.panel1.Controls.Add(this.bt_Transactions);
            this.panel1.Controls.Add(this.bt_cuentas);
            this.panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 658);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            // 
            // bt_Salir
            // 
            this.bt_Salir.BackColor = System.Drawing.Color.IndianRed;
            this.bt_Salir.FlatAppearance.BorderSize = 0;
            this.bt_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Salir.Location = new System.Drawing.Point(12, 592);
            this.bt_Salir.Name = "bt_Salir";
            this.bt_Salir.Size = new System.Drawing.Size(191, 33);
            this.bt_Salir.TabIndex = 3;
            this.bt_Salir.Text = "Salir";
            this.bt_Salir.UseVisualStyleBackColor = false;
            this.bt_Salir.Click += new System.EventHandler(this.bt_Salir_Click);
            // 
            // bt_Cerrar_Seccion
            // 
            this.bt_Cerrar_Seccion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Cerrar_Seccion.FlatAppearance.BorderSize = 0;
            this.bt_Cerrar_Seccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cerrar_Seccion.Location = new System.Drawing.Point(12, 553);
            this.bt_Cerrar_Seccion.Name = "bt_Cerrar_Seccion";
            this.bt_Cerrar_Seccion.Size = new System.Drawing.Size(191, 33);
            this.bt_Cerrar_Seccion.TabIndex = 2;
            this.bt_Cerrar_Seccion.Text = "Cerrar Seccion";
            this.bt_Cerrar_Seccion.UseVisualStyleBackColor = false;
            this.bt_Cerrar_Seccion.Click += new System.EventHandler(this.bt_Cerrar_Seccion_Click);
            // 
            // bt_User
            // 
            this.bt_User.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_User.FlatAppearance.BorderSize = 0;
            this.bt_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_User.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_User.Location = new System.Drawing.Point(12, 220);
            this.bt_User.Name = "bt_User";
            this.bt_User.Size = new System.Drawing.Size(191, 33);
            this.bt_User.TabIndex = 1;
            this.bt_User.Text = "Usuarios";
            this.bt_User.UseVisualStyleBackColor = false;
            this.bt_User.Click += new System.EventHandler(this.bt_User_Click);
            // 
            // bt_Transactions
            // 
            this.bt_Transactions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Transactions.FlatAppearance.BorderSize = 0;
            this.bt_Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Transactions.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_Transactions.Location = new System.Drawing.Point(12, 167);
            this.bt_Transactions.Name = "bt_Transactions";
            this.bt_Transactions.Size = new System.Drawing.Size(191, 33);
            this.bt_Transactions.TabIndex = 1;
            this.bt_Transactions.Text = "Transaciones";
            this.bt_Transactions.UseVisualStyleBackColor = false;
            this.bt_Transactions.Click += new System.EventHandler(this.bt_Transactions_Click);
            // 
            // bt_cuentas
            // 
            this.bt_cuentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_cuentas.FlatAppearance.BorderSize = 0;
            this.bt_cuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cuentas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cuentas.Location = new System.Drawing.Point(12, 114);
            this.bt_cuentas.Name = "bt_cuentas";
            this.bt_cuentas.Size = new System.Drawing.Size(191, 33);
            this.bt_cuentas.TabIndex = 1;
            this.bt_cuentas.Text = "Cuentas";
            this.bt_cuentas.UseVisualStyleBackColor = false;
            this.bt_cuentas.Click += new System.EventHandler(this.bt_cuentas_Click);
            // 
            // dvDashboard
            // 
            this.dvDashboard.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvDashboard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvDashboard.Location = new System.Drawing.Point(231, 87);
            this.dvDashboard.MultiSelect = false;
            this.dvDashboard.Name = "dvDashboard";
            this.dvDashboard.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvDashboard.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDashboard.Size = new System.Drawing.Size(751, 551);
            this.dvDashboard.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Informacion General";
            // 
            // bt_Update_dv
            // 
            this.bt_Update_dv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Update_dv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update_dv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Update_dv.Location = new System.Drawing.Point(897, 50);
            this.bt_Update_dv.Name = "bt_Update_dv";
            this.bt_Update_dv.Size = new System.Drawing.Size(85, 31);
            this.bt_Update_dv.TabIndex = 7;
            this.bt_Update_dv.Text = "Actualizar";
            this.bt_Update_dv.UseVisualStyleBackColor = false;
            this.bt_Update_dv.Click += new System.EventHandler(this.bt_Update_dv_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(994, 659);
            this.Controls.Add(this.bt_Update_dv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvDashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Salir;
        private System.Windows.Forms.Button bt_Cerrar_Seccion;
        private System.Windows.Forms.Button bt_User;
        private System.Windows.Forms.Button bt_Transactions;
        private System.Windows.Forms.Button bt_cuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Update_dv;
    }
}