namespace SysFinance.UI.Formularios
{
    partial class frmLancamentosConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentosConsultar));
            this.dgvLancamentos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segmento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodSegmento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnRemoverFiltro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnExportarXls = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportarPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprimir = new System.Windows.Forms.ToolStripSplitButton();
            this.btnImprimirPadrao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnPesquisarConta = new System.Windows.Forms.Button();
            this.txtDsConta = new System.Windows.Forms.TextBox();
            this.txtFkConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTpOperacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisarSeg = new System.Windows.Forms.Button();
            this.txtDsSegmento = new System.Windows.Forms.TextBox();
            this.txtFkSegmento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDtMovtoDe = new System.Windows.Forms.DateTimePicker();
            this.dtpDtMovtoAte = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).BeginInit();
            this.toolMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLancamentos
            // 
            this.dgvLancamentos.AllowUserToAddRows = false;
            this.dgvLancamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descrição,
            this.Data,
            this.Valor,
            this.Conta,
            this.Segmento,
            this.Tipo,
            this.Observação,
            this.FK_USUARIO,
            this.CodSegmento});
            this.dgvLancamentos.Location = new System.Drawing.Point(1, 117);
            this.dgvLancamentos.Name = "dgvLancamentos";
            this.dgvLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLancamentos.Size = new System.Drawing.Size(915, 319);
            this.dgvLancamentos.TabIndex = 26;
            this.dgvLancamentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLancamentos_MouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PK_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 45;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "DS_LANCTO";
            this.Descrição.HeaderText = "Desc.Lancto";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 350;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DT_LANCTO";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 80;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "VL_LANCTO";
            this.Valor.HeaderText = "Valor R$";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 90;
            // 
            // Conta
            // 
            this.Conta.DataPropertyName = "FK_CONTA";
            this.Conta.HeaderText = "Conta";
            this.Conta.Name = "Conta";
            this.Conta.ReadOnly = true;
            // 
            // Segmento
            // 
            this.Segmento.DataPropertyName = "DS_SEGMENTO";
            this.Segmento.HeaderText = "Segmento";
            this.Segmento.Name = "Segmento";
            this.Segmento.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TP_OPERACAO";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 60;
            // 
            // Observação
            // 
            this.Observação.DataPropertyName = "DS_OBS";
            this.Observação.HeaderText = "Observação";
            this.Observação.Name = "Observação";
            this.Observação.ReadOnly = true;
            this.Observação.Visible = false;
            // 
            // FK_USUARIO
            // 
            this.FK_USUARIO.DataPropertyName = "FK_USUARIO";
            this.FK_USUARIO.HeaderText = "Cod.Usuário";
            this.FK_USUARIO.Name = "FK_USUARIO";
            this.FK_USUARIO.Visible = false;
            // 
            // CodSegmento
            // 
            this.CodSegmento.DataPropertyName = "FK_SEGMENTO";
            this.CodSegmento.HeaderText = "Id.Segmento";
            this.CodSegmento.Name = "CodSegmento";
            this.CodSegmento.Visible = false;
            // 
            // toolMenu
            // 
            this.toolMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolMenu.AutoSize = false;
            this.toolMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtualizar,
            this.btnBuscar,
            this.btnRemoverFiltro,
            this.toolStripSeparator1,
            this.btnExportar,
            this.btnImprimir,
            this.toolStripSeparator2,
            this.btnInserir,
            this.btnAlterar,
            this.btnExcluir,
            this.toolStripLabel3,
            this.toolStripLabel2,
            this.toolStripLabel1});
            this.toolMenu.Location = new System.Drawing.Point(-1, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(918, 34);
            this.toolMenu.TabIndex = 21;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = false;
            this.btnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(30, 30);
            this.btnAtualizar.Text = "Refresh";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 31);
            this.btnBuscar.Text = "Filtrar por ID";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRemoverFiltro
            // 
            this.btnRemoverFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoverFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverFiltro.Image")));
            this.btnRemoverFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoverFiltro.Name = "btnRemoverFiltro";
            this.btnRemoverFiltro.Size = new System.Drawing.Size(24, 31);
            this.btnRemoverFiltro.Text = "Remover Filtro";
            this.btnRemoverFiltro.Click += new System.EventHandler(this.btnRemoverFiltro_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnExportar
            // 
            this.btnExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportarXls,
            this.btnExportarPdf});
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(36, 31);
            this.btnExportar.Text = "toolStripSplitButton1";
            this.btnExportar.ToolTipText = "Exportar dados";
            // 
            // btnExportarXls
            // 
            this.btnExportarXls.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarXls.Image")));
            this.btnExportarXls.Name = "btnExportarXls";
            this.btnExportarXls.Size = new System.Drawing.Size(95, 22);
            this.btnExportarXls.Text = "XLS";
            this.btnExportarXls.ToolTipText = "XLS";
            this.btnExportarXls.Click += new System.EventHandler(this.btnExportarXls_Click);
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPdf.Image")));
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(95, 22);
            this.btnExportarPdf.Text = "PDF";
            this.btnExportarPdf.ToolTipText = "PDF";
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimirPadrao});
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(36, 31);
            this.btnImprimir.Text = "toolStripSplitButton1";
            this.btnImprimir.Visible = false;
            // 
            // btnImprimirPadrao
            // 
            this.btnImprimirPadrao.Name = "btnImprimirPadrao";
            this.btnImprimirPadrao.Size = new System.Drawing.Size(152, 22);
            this.btnImprimirPadrao.Text = "Padrão";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // btnInserir
            // 
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 31);
            this.btnInserir.Text = "&Incluir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(66, 31);
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 31);
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(13, 31);
            this.toolStripLabel3.Text = "  ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 31);
            this.toolStripLabel2.Text = "  ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 31);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(828, 51);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 26);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnPesquisarConta
            // 
            this.btnPesquisarConta.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarConta.Image")));
            this.btnPesquisarConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarConta.Location = new System.Drawing.Point(68, 51);
            this.btnPesquisarConta.Name = "btnPesquisarConta";
            this.btnPesquisarConta.Size = new System.Drawing.Size(30, 20);
            this.btnPesquisarConta.TabIndex = 36;
            this.btnPesquisarConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarConta.UseVisualStyleBackColor = true;
            this.btnPesquisarConta.Click += new System.EventHandler(this.btnPesquisarConta_Click);
            // 
            // txtDsConta
            // 
            this.txtDsConta.Enabled = false;
            this.txtDsConta.Location = new System.Drawing.Point(100, 51);
            this.txtDsConta.Name = "txtDsConta";
            this.txtDsConta.Size = new System.Drawing.Size(181, 20);
            this.txtDsConta.TabIndex = 35;
            // 
            // txtFkConta
            // 
            this.txtFkConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFkConta.Location = new System.Drawing.Point(6, 51);
            this.txtFkConta.Name = "txtFkConta";
            this.txtFkConta.Size = new System.Drawing.Size(62, 20);
            this.txtFkConta.TabIndex = 0;
            this.txtFkConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFkConta_KeyDown);
            this.txtFkConta.Leave += new System.EventHandler(this.txtFkConta_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Conta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTpOperacao);
            this.groupBox1.Location = new System.Drawing.Point(694, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Operação";
            // 
            // cmbTpOperacao
            // 
            this.cmbTpOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTpOperacao.FormattingEnabled = true;
            this.cmbTpOperacao.Items.AddRange(new object[] {
            "T=Todos",
            "C=Crédito",
            "D=Débito"});
            this.cmbTpOperacao.Location = new System.Drawing.Point(6, 19);
            this.cmbTpOperacao.Name = "cmbTpOperacao";
            this.cmbTpOperacao.Size = new System.Drawing.Size(113, 21);
            this.cmbTpOperacao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Dt.Movimento até";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Dt.Movimento de:";
            // 
            // btnPesquisarSeg
            // 
            this.btnPesquisarSeg.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarSeg.Image")));
            this.btnPesquisarSeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarSeg.Location = new System.Drawing.Point(68, 92);
            this.btnPesquisarSeg.Name = "btnPesquisarSeg";
            this.btnPesquisarSeg.Size = new System.Drawing.Size(30, 20);
            this.btnPesquisarSeg.TabIndex = 3;
            this.btnPesquisarSeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarSeg.UseVisualStyleBackColor = true;
            this.btnPesquisarSeg.Click += new System.EventHandler(this.btnPesquisarSeg_Click);
            // 
            // txtDsSegmento
            // 
            this.txtDsSegmento.Enabled = false;
            this.txtDsSegmento.Location = new System.Drawing.Point(100, 92);
            this.txtDsSegmento.Name = "txtDsSegmento";
            this.txtDsSegmento.Size = new System.Drawing.Size(181, 20);
            this.txtDsSegmento.TabIndex = 44;
            // 
            // txtFkSegmento
            // 
            this.txtFkSegmento.Location = new System.Drawing.Point(6, 92);
            this.txtFkSegmento.Name = "txtFkSegmento";
            this.txtFkSegmento.Size = new System.Drawing.Size(62, 20);
            this.txtFkSegmento.TabIndex = 2;
            this.txtFkSegmento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFkSegmento_KeyDown);
            this.txtFkSegmento.Leave += new System.EventHandler(this.txtFkSegmento_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Segmento";
            // 
            // dtpDtMovtoDe
            // 
            this.dtpDtMovtoDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtMovtoDe.Location = new System.Drawing.Point(299, 53);
            this.dtpDtMovtoDe.Name = "dtpDtMovtoDe";
            this.dtpDtMovtoDe.Size = new System.Drawing.Size(111, 20);
            this.dtpDtMovtoDe.TabIndex = 4;
            // 
            // dtpDtMovtoAte
            // 
            this.dtpDtMovtoAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtMovtoAte.Location = new System.Drawing.Point(425, 54);
            this.dtpDtMovtoAte.Name = "dtpDtMovtoAte";
            this.dtpDtMovtoAte.Size = new System.Drawing.Size(111, 20);
            this.dtpDtMovtoAte.TabIndex = 5;
            // 
            // frmLancamentosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(919, 438);
            this.Controls.Add(this.dtpDtMovtoAte);
            this.Controls.Add(this.dtpDtMovtoDe);
            this.Controls.Add(this.btnPesquisarSeg);
            this.Controls.Add(this.txtDsSegmento);
            this.Controls.Add(this.txtFkSegmento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisarConta);
            this.Controls.Add(this.txtDsConta);
            this.Controls.Add(this.txtFkConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvLancamentos);
            this.Controls.Add(this.toolMenu);
            this.Name = "frmLancamentosConsultar";
            this.Text = "Consultar lançamentos financeiros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).EndInit();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLancamentos;
        public System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnRemoverFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton btnExportar;
        private System.Windows.Forms.ToolStripMenuItem btnExportarXls;
        private System.Windows.Forms.ToolStripMenuItem btnExportarPdf;
        private System.Windows.Forms.ToolStripSplitButton btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem btnImprimirPadrao;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        protected System.Windows.Forms.Button btnConsultar;
        protected System.Windows.Forms.Button btnPesquisarConta;
        private System.Windows.Forms.TextBox txtDsConta;
        private System.Windows.Forms.TextBox txtFkConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button btnPesquisarSeg;
        private System.Windows.Forms.TextBox txtDsSegmento;
        private System.Windows.Forms.TextBox txtFkSegmento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTpOperacao;
        private System.Windows.Forms.DateTimePicker dtpDtMovtoDe;
        private System.Windows.Forms.DateTimePicker dtpDtMovtoAte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segmento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSegmento;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
