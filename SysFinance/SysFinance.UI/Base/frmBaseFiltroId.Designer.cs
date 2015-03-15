namespace SysFinance.UI.Base
{
    partial class frmBaseFiltroId
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
            this.txtPkId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(105, 58);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 58);
            this.btnOk.TabIndex = 1;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPkId
            // 
            this.txtPkId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPkId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPkId.Location = new System.Drawing.Point(12, 27);
            this.txtPkId.MaxLength = 8;
            this.txtPkId.Name = "txtPkId";
            this.txtPkId.Size = new System.Drawing.Size(174, 20);
            this.txtPkId.TabIndex = 0;
            this.txtPkId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPkId_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID a procurar";
            // 
            // frmBaseFiltroId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(203, 100);
            this.Controls.Add(this.txtPkId);
            this.Controls.Add(this.label1);
            this.Name = "frmBaseFiltroId";
            this.Text = "Filtrar pelo ID";
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPkId, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPkId;
        private System.Windows.Forms.Label label1;
    }
}
