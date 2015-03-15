namespace SysFinance.UI.Formularios
{
    partial class frmLancamentosDigitar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentosDigitar));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDsLancto = new System.Windows.Forms.TextBox();
            this.txtVlLancto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpTpOperacao = new System.Windows.Forms.GroupBox();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarSeg = new System.Windows.Forms.Button();
            this.txtDsSegmento = new System.Windows.Forms.TextBox();
            this.txtFkSegmento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisarConta = new System.Windows.Forms.Button();
            this.txtDsConta = new System.Windows.Forms.TextBox();
            this.txtFkConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDsObs = new System.Windows.Forms.TextBox();
            this.dtpDtLancto = new System.Windows.Forms.DateTimePicker();
            this.grpTpOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 382);
            this.btnCancelar.Size = new System.Drawing.Size(90, 28);
            this.btnCancelar.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(202, 382);
            this.btnOk.Size = new System.Drawing.Size(90, 28);
            this.btnOk.TabIndex = 7;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição do Lançamento (*)";
            // 
            // txtDsLancto
            // 
            this.txtDsLancto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDsLancto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDsLancto.Location = new System.Drawing.Point(18, 211);
            this.txtDsLancto.Name = "txtDsLancto";
            this.txtDsLancto.Size = new System.Drawing.Size(366, 20);
            this.txtDsLancto.TabIndex = 6;
            // 
            // txtVlLancto
            // 
            this.txtVlLancto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVlLancto.Location = new System.Drawing.Point(18, 85);
            this.txtVlLancto.Name = "txtVlLancto";
            this.txtVlLancto.Size = new System.Drawing.Size(111, 20);
            this.txtVlLancto.TabIndex = 1;
            this.txtVlLancto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digitar);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor R$ ( * )";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Lançamento ( * )";
            // 
            // grpTpOperacao
            // 
            this.grpTpOperacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpTpOperacao.Controls.Add(this.rdbCredito);
            this.grpTpOperacao.Controls.Add(this.rdbDebito);
            this.grpTpOperacao.Location = new System.Drawing.Point(475, 18);
            this.grpTpOperacao.Name = "grpTpOperacao";
            this.grpTpOperacao.Size = new System.Drawing.Size(93, 64);
            this.grpTpOperacao.TabIndex = 7;
            this.grpTpOperacao.TabStop = false;
            this.grpTpOperacao.Text = "Operação";
            // 
            // rdbCredito
            // 
            this.rdbCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(15, 41);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(71, 17);
            this.rdbCredito.TabIndex = 13;
            this.rdbCredito.Text = "C=Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // rdbDebito
            // 
            this.rdbDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Checked = true;
            this.rdbDebito.Location = new System.Drawing.Point(15, 18);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(70, 17);
            this.rdbDebito.TabIndex = 11;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "D=Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            this.rdbDebito.CheckedChanged += new System.EventHandler(this.rdbDebito_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Observações";
            // 
            // btnPesquisarSeg
            // 
            this.btnPesquisarSeg.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarSeg.Image")));
            this.btnPesquisarSeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarSeg.Location = new System.Drawing.Point(80, 168);
            this.btnPesquisarSeg.Name = "btnPesquisarSeg";
            this.btnPesquisarSeg.Size = new System.Drawing.Size(30, 20);
            this.btnPesquisarSeg.TabIndex = 5;
            this.btnPesquisarSeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarSeg.UseVisualStyleBackColor = true;
            this.btnPesquisarSeg.Click += new System.EventHandler(this.btnPesquisarSeg_Click);
            // 
            // txtDsSegmento
            // 
            this.txtDsSegmento.Enabled = false;
            this.txtDsSegmento.Location = new System.Drawing.Point(112, 168);
            this.txtDsSegmento.Name = "txtDsSegmento";
            this.txtDsSegmento.Size = new System.Drawing.Size(181, 20);
            this.txtDsSegmento.TabIndex = 52;
            // 
            // txtFkSegmento
            // 
            this.txtFkSegmento.Location = new System.Drawing.Point(18, 168);
            this.txtFkSegmento.Name = "txtFkSegmento";
            this.txtFkSegmento.Size = new System.Drawing.Size(62, 20);
            this.txtFkSegmento.TabIndex = 4;
            this.txtFkSegmento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFkSegmento_KeyDown);
            this.txtFkSegmento.Leave += new System.EventHandler(this.txtFkSegmento_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Segmento ( * )";
            // 
            // btnPesquisarConta
            // 
            this.btnPesquisarConta.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarConta.Image")));
            this.btnPesquisarConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarConta.Location = new System.Drawing.Point(80, 127);
            this.btnPesquisarConta.Name = "btnPesquisarConta";
            this.btnPesquisarConta.Size = new System.Drawing.Size(30, 20);
            this.btnPesquisarConta.TabIndex = 3;
            this.btnPesquisarConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarConta.UseVisualStyleBackColor = true;
            this.btnPesquisarConta.Click += new System.EventHandler(this.btnPesquisarConta_Click);
            // 
            // txtDsConta
            // 
            this.txtDsConta.Enabled = false;
            this.txtDsConta.Location = new System.Drawing.Point(112, 127);
            this.txtDsConta.Name = "txtDsConta";
            this.txtDsConta.Size = new System.Drawing.Size(181, 20);
            this.txtDsConta.TabIndex = 48;
            // 
            // txtFkConta
            // 
            this.txtFkConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFkConta.Location = new System.Drawing.Point(18, 127);
            this.txtFkConta.Name = "txtFkConta";
            this.txtFkConta.Size = new System.Drawing.Size(62, 20);
            this.txtFkConta.TabIndex = 3;
            this.txtFkConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFkConta_KeyDown);
            this.txtFkConta.Leave += new System.EventHandler(this.txtFkConta_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Conta ( * )";
            // 
            // txtDsObs
            // 
            this.txtDsObs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDsObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDsObs.Location = new System.Drawing.Point(18, 260);
            this.txtDsObs.Multiline = true;
            this.txtDsObs.Name = "txtDsObs";
            this.txtDsObs.Size = new System.Drawing.Size(550, 105);
            this.txtDsObs.TabIndex = 6;
            // 
            // dtpDtLancto
            // 
            this.dtpDtLancto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtLancto.Location = new System.Drawing.Point(18, 36);
            this.dtpDtLancto.Name = "dtpDtLancto";
            this.dtpDtLancto.Size = new System.Drawing.Size(111, 20);
            this.dtpDtLancto.TabIndex = 0;
            // 
            // frmLancamentosDigitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(596, 421);
            this.Controls.Add(this.dtpDtLancto);
            this.Controls.Add(this.txtDsObs);
            this.Controls.Add(this.btnPesquisarSeg);
            this.Controls.Add(this.txtDsSegmento);
            this.Controls.Add(this.txtFkSegmento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisarConta);
            this.Controls.Add(this.txtDsConta);
            this.Controls.Add(this.txtFkConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpTpOperacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVlLancto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDsLancto);
            this.Controls.Add(this.label1);
            this.Name = "frmLancamentosDigitar";
            this.Text = "Cadastrar Lançamento";
            this.Load += new System.EventHandler(this.frmLancamentosDigitar_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDsLancto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtVlLancto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.grpTpOperacao, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtFkConta, 0);
            this.Controls.SetChildIndex(this.txtDsConta, 0);
            this.Controls.SetChildIndex(this.btnPesquisarConta, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtFkSegmento, 0);
            this.Controls.SetChildIndex(this.txtDsSegmento, 0);
            this.Controls.SetChildIndex(this.btnPesquisarSeg, 0);
            this.Controls.SetChildIndex(this.txtDsObs, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.dtpDtLancto, 0);
            this.grpTpOperacao.ResumeLayout(false);
            this.grpTpOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDsLancto;
        private System.Windows.Forms.TextBox txtVlLancto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpTpOperacao;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button btnPesquisarSeg;
        private System.Windows.Forms.TextBox txtDsSegmento;
        private System.Windows.Forms.TextBox txtFkSegmento;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button btnPesquisarConta;
        private System.Windows.Forms.TextBox txtDsConta;
        private System.Windows.Forms.TextBox txtFkConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDsObs;
        private System.Windows.Forms.DateTimePicker dtpDtLancto;
        private System.Windows.Forms.RadioButton rdbCredito;
    }
}
