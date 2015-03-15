namespace SysFinance.UI.Formularios
{
    partial class frmAjuda
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lstRotinas = new System.Windows.Forms.ListBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.chkAutoAjuda = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(192, 21);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(703, 364);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // lstRotinas
            // 
            this.lstRotinas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRotinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRotinas.FormattingEnabled = true;
            this.lstRotinas.ItemHeight = 15;
            this.lstRotinas.Items.AddRange(new object[] {
            "1. Menu Principal",
            "2. Arquivo",
            "  2.1 Logoff",
            "3. Cadastros Básicos",
            "  3.1 Contas",
            "    3.1.2 Inserindo\\Alterando",
            "  3.2 Segmentos",
            "    3.2.1 Inserindo\\Alterando",
            "  3.3 Usuários",
            "    3.3.1 Inserindo\\Alterando",
            "  3.4 Configurar Acesso",
            "  3.5 Trocar Senha",
            "4. Movimentos",
            "  4.1 Lançamentos",
            "  4.1.2 Inserindo\\Alterando",
            "5. Relatórios",
            "  5.1 Extrato de Contas",
            "  5.2 Fluxo de Caixa",
            "6. Exportar dados",
            "6.1 Pesquisando dados"});
            this.lstRotinas.Location = new System.Drawing.Point(1, 21);
            this.lstRotinas.Name = "lstRotinas";
            this.lstRotinas.Size = new System.Drawing.Size(185, 364);
            this.lstRotinas.TabIndex = 0;
            this.lstRotinas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.lstRotinas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(1, 388);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(894, 117);
            this.lblTexto.TabIndex = 2;
            // 
            // chkAutoAjuda
            // 
            this.chkAutoAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoAjuda.AutoSize = true;
            this.chkAutoAjuda.Location = new System.Drawing.Point(711, 1);
            this.chkAutoAjuda.Name = "chkAutoAjuda";
            this.chkAutoAjuda.Size = new System.Drawing.Size(184, 17);
            this.chkAutoAjuda.TabIndex = 3;
            this.chkAutoAjuda.Text = "Não exibir novamente Auto Ajuda";
            this.chkAutoAjuda.UseVisualStyleBackColor = true;
            // 
            // frmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(899, 514);
            this.Controls.Add(this.chkAutoAjuda);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lstRotinas);
            this.Name = "frmAjuda";
            this.Text = "Ajuda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAjuda_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRotinas;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.CheckBox chkAutoAjuda;
    }
}
