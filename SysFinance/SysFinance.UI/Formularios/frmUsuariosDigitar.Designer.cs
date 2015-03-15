namespace SysFinance.UI.Formularios
{
    partial class frmUsuariosDigitar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDsNome = new System.Windows.Forms.TextBox();
            this.txtDsSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDsLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDsEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 261);
            this.btnCancelar.Size = new System.Drawing.Size(77, 29);
            this.btnCancelar.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(70, 261);
            this.btnOk.Size = new System.Drawing.Size(81, 29);
            this.btnOk.TabIndex = 10;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome de Usuário ( * )";
            // 
            // txtDsNome
            // 
            this.txtDsNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDsNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDsNome.Location = new System.Drawing.Point(24, 35);
            this.txtDsNome.Name = "txtDsNome";
            this.txtDsNome.Size = new System.Drawing.Size(265, 20);
            this.txtDsNome.TabIndex = 1;
            // 
            // txtDsSenha
            // 
            this.txtDsSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDsSenha.Location = new System.Drawing.Point(24, 177);
            this.txtDsSenha.Name = "txtDsSenha";
            this.txtDsSenha.PasswordChar = '*';
            this.txtDsSenha.Size = new System.Drawing.Size(265, 20);
            this.txtDsSenha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha ( * )";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(24, 220);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = '*';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(265, 20);
            this.txtConfirmaSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirmar Senha ( * )";
            // 
            // txtDsLogin
            // 
            this.txtDsLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDsLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDsLogin.Location = new System.Drawing.Point(24, 84);
            this.txtDsLogin.Name = "txtDsLogin";
            this.txtDsLogin.Size = new System.Drawing.Size(265, 20);
            this.txtDsLogin.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-mail";
            // 
            // txtDsEmail
            // 
            this.txtDsEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDsEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDsEmail.Location = new System.Drawing.Point(24, 131);
            this.txtDsEmail.Name = "txtDsEmail";
            this.txtDsEmail.Size = new System.Drawing.Size(265, 20);
            this.txtDsEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Login ( * )";
            // 
            // frmUsuariosDigitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(317, 302);
            this.Controls.Add(this.txtDsEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDsLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDsSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDsNome);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuariosDigitar";
            this.Text = "Cadastro de Usuários";
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDsNome, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDsSenha, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtConfirmaSenha, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDsLogin, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDsEmail, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDsNome;
        private System.Windows.Forms.TextBox txtDsSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDsLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDsEmail;
        private System.Windows.Forms.Label label5;

    }
}
