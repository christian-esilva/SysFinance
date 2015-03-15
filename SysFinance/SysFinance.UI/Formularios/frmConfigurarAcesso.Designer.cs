namespace SysFinance.UI.Formularios
{
    partial class frmConfigurarAcesso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTgLancto = new System.Windows.Forms.CheckBox();
            this.chkTgContas = new System.Windows.Forms.CheckBox();
            this.chkTgSegmento = new System.Windows.Forms.CheckBox();
            this.chkTgUsuario = new System.Windows.Forms.CheckBox();
            this.txtDsUsuario = new System.Windows.Forms.TextBox();
            this.txtFkUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkExtratoContas = new System.Windows.Forms.CheckBox();
            this.chkFluxoCaixa = new System.Windows.Forms.CheckBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(151, 271);
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(62, 271);
            this.btnOk.Size = new System.Drawing.Size(83, 28);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkTgLancto);
            this.groupBox1.Controls.Add(this.chkTgContas);
            this.groupBox1.Controls.Add(this.chkTgSegmento);
            this.groupBox1.Controls.Add(this.chkTgUsuario);
            this.groupBox1.Location = new System.Drawing.Point(15, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 113);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastros básicos";
            // 
            // chkTgLancto
            // 
            this.chkTgLancto.AutoSize = true;
            this.chkTgLancto.Location = new System.Drawing.Point(13, 88);
            this.chkTgLancto.Name = "chkTgLancto";
            this.chkTgLancto.Size = new System.Drawing.Size(147, 17);
            this.chkTgLancto.TabIndex = 47;
            this.chkTgLancto.Text = "Lançamentos Financeiros";
            this.chkTgLancto.UseVisualStyleBackColor = true;
            // 
            // chkTgContas
            // 
            this.chkTgContas.AutoSize = true;
            this.chkTgContas.Location = new System.Drawing.Point(13, 65);
            this.chkTgContas.Name = "chkTgContas";
            this.chkTgContas.Size = new System.Drawing.Size(59, 17);
            this.chkTgContas.TabIndex = 46;
            this.chkTgContas.Text = "Contas";
            this.chkTgContas.UseVisualStyleBackColor = true;
            // 
            // chkTgSegmento
            // 
            this.chkTgSegmento.AutoSize = true;
            this.chkTgSegmento.Location = new System.Drawing.Point(13, 42);
            this.chkTgSegmento.Name = "chkTgSegmento";
            this.chkTgSegmento.Size = new System.Drawing.Size(79, 17);
            this.chkTgSegmento.TabIndex = 45;
            this.chkTgSegmento.Text = "Segmentos";
            this.chkTgSegmento.UseVisualStyleBackColor = true;
            // 
            // chkTgUsuario
            // 
            this.chkTgUsuario.AutoSize = true;
            this.chkTgUsuario.Location = new System.Drawing.Point(13, 19);
            this.chkTgUsuario.Name = "chkTgUsuario";
            this.chkTgUsuario.Size = new System.Drawing.Size(67, 17);
            this.chkTgUsuario.TabIndex = 44;
            this.chkTgUsuario.Text = "Usuários";
            this.chkTgUsuario.UseVisualStyleBackColor = true;
            // 
            // txtDsUsuario
            // 
            this.txtDsUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDsUsuario.Enabled = false;
            this.txtDsUsuario.Location = new System.Drawing.Point(76, 24);
            this.txtDsUsuario.Name = "txtDsUsuario";
            this.txtDsUsuario.ReadOnly = true;
            this.txtDsUsuario.Size = new System.Drawing.Size(225, 20);
            this.txtDsUsuario.TabIndex = 44;
            // 
            // txtFkUsuario
            // 
            this.txtFkUsuario.Enabled = false;
            this.txtFkUsuario.Location = new System.Drawing.Point(15, 24);
            this.txtFkUsuario.Name = "txtFkUsuario";
            this.txtFkUsuario.Size = new System.Drawing.Size(55, 20);
            this.txtFkUsuario.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkExtratoContas);
            this.groupBox2.Controls.Add(this.chkFluxoCaixa);
            this.groupBox2.Location = new System.Drawing.Point(15, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 69);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatórios";
            // 
            // chkExtratoContas
            // 
            this.chkExtratoContas.AutoSize = true;
            this.chkExtratoContas.Location = new System.Drawing.Point(13, 42);
            this.chkExtratoContas.Name = "chkExtratoContas";
            this.chkExtratoContas.Size = new System.Drawing.Size(110, 17);
            this.chkExtratoContas.TabIndex = 50;
            this.chkExtratoContas.Text = "Extrato de Contas";
            this.chkExtratoContas.UseVisualStyleBackColor = true;
            // 
            // chkFluxoCaixa
            // 
            this.chkFluxoCaixa.AutoSize = true;
            this.chkFluxoCaixa.Location = new System.Drawing.Point(13, 19);
            this.chkFluxoCaixa.Name = "chkFluxoCaixa";
            this.chkFluxoCaixa.Size = new System.Drawing.Size(97, 17);
            this.chkFluxoCaixa.TabIndex = 49;
            this.chkFluxoCaixa.Text = "Fluxo De Caixa";
            this.chkFluxoCaixa.UseVisualStyleBackColor = true;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(28, 244);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(144, 17);
            this.chkTodos.TabIndex = 51;
            this.chkTodos.Text = "Marcar/Desmarcar todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // frmConfigurarAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(324, 308);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFkUsuario);
            this.Controls.Add(this.txtDsUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmConfigurarAcesso";
            this.Text = "Configurar Acesso";
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtDsUsuario, 0);
            this.Controls.SetChildIndex(this.txtFkUsuario, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.chkTodos, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTgLancto;
        private System.Windows.Forms.CheckBox chkTgContas;
        private System.Windows.Forms.CheckBox chkTgSegmento;
        private System.Windows.Forms.CheckBox chkTgUsuario;
        private System.Windows.Forms.TextBox txtDsUsuario;
        private System.Windows.Forms.TextBox txtFkUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkExtratoContas;
        private System.Windows.Forms.CheckBox chkFluxoCaixa;
        private System.Windows.Forms.CheckBox chkTodos;
    }
}
