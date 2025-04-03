namespace ManagerFinances
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_gmail = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_VisiablePassword_Login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de seccion";
            // 
            // tb_gmail
            // 
            this.tb_gmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_gmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_gmail.Location = new System.Drawing.Point(96, 79);
            this.tb_gmail.Name = "tb_gmail";
            this.tb_gmail.Size = new System.Drawing.Size(198, 27);
            this.tb_gmail.TabIndex = 1;
            this.tb_gmail.TabStop = false;
            this.tb_gmail.Text = "Correo";
            this.tb_gmail.Enter += new System.EventHandler(this.tb_gmail_Enter);
            this.tb_gmail.Leave += new System.EventHandler(this.tb_gmail_Leave);
            // 
            // tb_Password
            // 
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_Password.Location = new System.Drawing.Point(96, 132);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(198, 27);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TabStop = false;
            this.tb_Password.Text = "Contraseña";
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_iniciar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_iniciar.Location = new System.Drawing.Point(149, 184);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(89, 32);
            this.bt_iniciar.TabIndex = 3;
            this.bt_iniciar.TabStop = false;
            this.bt_iniciar.Text = "Iniciar";
            this.bt_iniciar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_VisiablePassword_Login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_iniciar);
            this.panel1.Controls.Add(this.tb_gmail);
            this.panel1.Controls.Add(this.tb_Password);
            this.panel1.Location = new System.Drawing.Point(103, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 272);
            this.panel1.TabIndex = 0;
            // 
            // bt_VisiablePassword_Login
            // 
            this.bt_VisiablePassword_Login.BackColor = System.Drawing.Color.White;
            this.bt_VisiablePassword_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_VisiablePassword_Login.ForeColor = System.Drawing.Color.White;
            this.bt_VisiablePassword_Login.Image = ((System.Drawing.Image)(resources.GetObject("bt_VisiablePassword_Login.Image")));
            this.bt_VisiablePassword_Login.Location = new System.Drawing.Point(266, 138);
            this.bt_VisiablePassword_Login.Name = "bt_VisiablePassword_Login";
            this.bt_VisiablePassword_Login.Size = new System.Drawing.Size(27, 15);
            this.bt_VisiablePassword_Login.TabIndex = 13;
            this.bt_VisiablePassword_Login.UseVisualStyleBackColor = false;
            this.bt_VisiablePassword_Login.Click += new System.EventHandler(this.bt_VisiablePassword_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_gmail;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_VisiablePassword_Login;
    }
}

