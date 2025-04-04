namespace ManagerFinances.Forms
{
    partial class Transation
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
            this.label1 = new System.Windows.Forms.Label();
            this.dvTransation = new System.Windows.Forms.DataGridView();
            this.tb_Monto = new System.Windows.Forms.TextBox();
            this.tb_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Categoria = new System.Windows.Forms.ComboBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Edit_Transaction = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Cuenta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvTransation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestor de Transacciones";
            // 
            // dvTransation
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvTransation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvTransation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvTransation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvTransation.Location = new System.Drawing.Point(32, 63);
            this.dvTransation.MultiSelect = false;
            this.dvTransation.Name = "dvTransation";
            this.dvTransation.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvTransation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvTransation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTransation.Size = new System.Drawing.Size(600, 285);
            this.dvTransation.TabIndex = 1;
            // 
            // tb_Monto
            // 
            this.tb_Monto.Location = new System.Drawing.Point(315, 373);
            this.tb_Monto.Name = "tb_Monto";
            this.tb_Monto.Size = new System.Drawing.Size(121, 20);
            this.tb_Monto.TabIndex = 3;
            // 
            // tb_Descripcion
            // 
            this.tb_Descripcion.Location = new System.Drawing.Point(32, 373);
            this.tb_Descripcion.Multiline = true;
            this.tb_Descripcion.Name = "tb_Descripcion";
            this.tb_Descripcion.Size = new System.Drawing.Size(273, 111);
            this.tb_Descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto";
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.Location = new System.Drawing.Point(315, 417);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_Categoria.TabIndex = 6;
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Add.FlatAppearance.BorderSize = 0;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(459, 408);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(79, 30);
            this.bt_Add.TabIndex = 8;
            this.bt_Add.Text = "Añadir";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Edit_Transaction
            // 
            this.bt_Edit_Transaction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Edit_Transaction.FlatAppearance.BorderSize = 0;
            this.bt_Edit_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit_Transaction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit_Transaction.Location = new System.Drawing.Point(553, 408);
            this.bt_Edit_Transaction.Name = "bt_Edit_Transaction";
            this.bt_Edit_Transaction.Size = new System.Drawing.Size(79, 30);
            this.bt_Edit_Transaction.TabIndex = 9;
            this.bt_Edit_Transaction.Text = "Editar";
            this.bt_Edit_Transaction.UseVisualStyleBackColor = false;
            this.bt_Edit_Transaction.Click += new System.EventHandler(this.bt_Edit_Transaction_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Delete.FlatAppearance.BorderSize = 0;
            this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(459, 454);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(173, 30);
            this.bt_Delete.TabIndex = 10;
            this.bt_Delete.Text = "Eliminar";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria";
            // 
            // cb_Cuenta
            // 
            this.cb_Cuenta.FormattingEnabled = true;
            this.cb_Cuenta.Location = new System.Drawing.Point(315, 463);
            this.cb_Cuenta.Name = "cb_Cuenta";
            this.cb_Cuenta.Size = new System.Drawing.Size(121, 21);
            this.cb_Cuenta.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cuenta";
            // 
            // Transation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(684, 509);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Cuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Edit_Transaction);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.cb_Categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Descripcion);
            this.Controls.Add(this.tb_Monto);
            this.Controls.Add(this.dvTransation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Transation";
            this.Text = "Transation";
            ((System.ComponentModel.ISupportInitialize)(this.dvTransation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvTransation;
        private System.Windows.Forms.TextBox tb_Monto;
        private System.Windows.Forms.TextBox tb_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Categoria;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Edit_Transaction;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Cuenta;
        private System.Windows.Forms.Label label5;
    }
}