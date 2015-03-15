namespace SysFinance.UI.Formularios
{
    partial class frmContasDigitar
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
            this.txtDsConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDsCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(166, 114);
            this.btnCancelar.Size = new System.Drawing.Size(92, 28);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(71, 114);
            this.btnOk.Size = new System.Drawing.Size(89, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código ( * )";
            // 
            // txtDsConta
            // 
            this.txtDsConta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDsConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDsConta.Location = new System.Drawing.Point(15, 73);
            this.txtDsConta.MaxLength = 80;
            this.txtDsConta.Name = "txtDsConta";
            this.txtDsConta.Size = new System.Drawing.Size(343, 20);
            this.txtDsConta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição ( * )";
            // 
            // txtDsCodigo
            // 
            this.txtDsCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDsCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDsCodigo.Location = new System.Drawing.Point(16, 25);
            this.txtDsCodigo.MaxLength = 8;
            this.txtDsCodigo.Name = "txtDsCodigo";
            this.txtDsCodigo.Size = new System.Drawing.Size(174, 20);
            this.txtDsCodigo.TabIndex = 0;
            // 
            // frmContasDigitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(367, 145);
            this.Controls.Add(this.txtDsCodigo);
            this.Controls.Add(this.txtDsConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmContasDigitar";
            this.Text = "Cadastro de Contas";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDsConta, 0);
            this.Controls.SetChildIndex(this.txtDsCodigo, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDsConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDsCodigo;
    }
}
