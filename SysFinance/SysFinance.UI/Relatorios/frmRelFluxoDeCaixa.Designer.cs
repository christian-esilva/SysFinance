namespace SysFinance.UI.Formularios
{
    partial class frmRelFluxoDeCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelFluxoDeCaixa));
            this.dgvFluxoDeCaixa = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Histórico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSaldoFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFkConta = new System.Windows.Forms.TextBox();
            this.txtDsConta = new System.Windows.Forms.TextBox();
            this.btnPesquisarConta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFkSegmento = new System.Windows.Forms.TextBox();
            this.txtDsSegmento = new System.Windows.Forms.TextBox();
            this.btnPesquisarSegmento = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDtMovtoAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDtMovtoDe = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTpOperacao = new System.Windows.Forms.ComboBox();
            this.txtTotalDebito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalCredito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnRemoverFiltro = new System.Windows.Forms.ToolStripButton();
            this.btnExportar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnExportarXls = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportarPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImprimir = new System.Windows.Forms.ToolStripSplitButton();
            this.btnImprimirPadrao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbcRelatorio.SuspendLayout();
            this.tbpOpcoes.SuspendLayout();
            this.tbpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoDeCaixa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRelatorio
            // 
            this.tbcRelatorio.Size = new System.Drawing.Size(703, 437);
            // 
            // tbpOpcoes
            // 
            this.tbpOpcoes.Controls.Add(this.groupBox2);
            this.tbpOpcoes.Controls.Add(this.dtpDtMovtoAte);
            this.tbpOpcoes.Controls.Add(this.dtpDtMovtoDe);
            this.tbpOpcoes.Controls.Add(this.label2);
            this.tbpOpcoes.Controls.Add(this.label1);
            this.tbpOpcoes.Controls.Add(this.txtFkSegmento);
            this.tbpOpcoes.Controls.Add(this.txtDsSegmento);
            this.tbpOpcoes.Controls.Add(this.btnPesquisarSegmento);
            this.tbpOpcoes.Controls.Add(this.label7);
            this.tbpOpcoes.Controls.Add(this.txtFkConta);
            this.tbpOpcoes.Controls.Add(this.txtDsConta);
            this.tbpOpcoes.Controls.Add(this.btnPesquisarConta);
            this.tbpOpcoes.Controls.Add(this.label4);
            this.tbpOpcoes.Size = new System.Drawing.Size(695, 411);
            this.tbpOpcoes.Controls.SetChildIndex(this.btnProsseguir, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.btnCancelar, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.panel1, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.label4, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.btnPesquisarConta, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.txtDsConta, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.txtFkConta, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.label7, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.btnPesquisarSegmento, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.txtDsSegmento, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.txtFkSegmento, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.label1, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.label2, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.dtpDtMovtoDe, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.dtpDtMovtoAte, 0);
            this.tbpOpcoes.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // tbpDados
            // 
            this.tbpDados.Controls.Add(this.label5);
            this.tbpDados.Controls.Add(this.txtSaldoInicial);
            this.tbpDados.Controls.Add(this.txtTotalCredito);
            this.tbpDados.Controls.Add(this.label8);
            this.tbpDados.Controls.Add(this.txtTotalDebito);
            this.tbpDados.Controls.Add(this.label3);
            this.tbpDados.Controls.Add(this.txtSaldoFinal);
            this.tbpDados.Controls.Add(this.label6);
            this.tbpDados.Controls.Add(this.dgvFluxoDeCaixa);
            this.tbpDados.Controls.Add(this.toolMenu);
            this.tbpDados.Size = new System.Drawing.Size(695, 411);
            this.tbpDados.Controls.SetChildIndex(this.lblExibido, 0);
            this.tbpDados.Controls.SetChildIndex(this.toolMenu, 0);
            this.tbpDados.Controls.SetChildIndex(this.dgvFluxoDeCaixa, 0);
            this.tbpDados.Controls.SetChildIndex(this.label6, 0);
            this.tbpDados.Controls.SetChildIndex(this.txtSaldoFinal, 0);
            this.tbpDados.Controls.SetChildIndex(this.label3, 0);
            this.tbpDados.Controls.SetChildIndex(this.txtTotalDebito, 0);
            this.tbpDados.Controls.SetChildIndex(this.label8, 0);
            this.tbpDados.Controls.SetChildIndex(this.txtTotalCredito, 0);
            this.tbpDados.Controls.SetChildIndex(this.txtSaldoInicial, 0);
            this.tbpDados.Controls.SetChildIndex(this.label5, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(597, 365);
            this.btnCancelar.TabIndex = 6;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.TabIndex = 5;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(702, 1);
            // 
            // lblExibido
            // 
            this.lblExibido.Location = new System.Drawing.Point(499, 15);
            this.lblExibido.Text = "Exibido em: DATA";
            // 
            // dgvFluxoDeCaixa
            // 
            this.dgvFluxoDeCaixa.AllowUserToAddRows = false;
            this.dgvFluxoDeCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFluxoDeCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxoDeCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Histórico,
            this.TipoOperacao,
            this.Entrada,
            this.Saida,
            this.Saldo});
            this.dgvFluxoDeCaixa.Location = new System.Drawing.Point(3, 37);
            this.dgvFluxoDeCaixa.Name = "dgvFluxoDeCaixa";
            this.dgvFluxoDeCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFluxoDeCaixa.Size = new System.Drawing.Size(689, 342);
            this.dgvFluxoDeCaixa.TabIndex = 1;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DT_LANCTO";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 70;
            // 
            // Histórico
            // 
            this.Histórico.DataPropertyName = "DS_LANCTO";
            this.Histórico.HeaderText = "Descrição";
            this.Histórico.Name = "Histórico";
            this.Histórico.ReadOnly = true;
            this.Histórico.Width = 220;
            // 
            // TipoOperacao
            // 
            this.TipoOperacao.DataPropertyName = "TP_OPERACAO";
            this.TipoOperacao.HeaderText = "Tipo";
            this.TipoOperacao.Name = "TipoOperacao";
            this.TipoOperacao.Width = 35;
            // 
            // Entrada
            // 
            this.Entrada.DataPropertyName = "VL_ENTRADA";
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Saida
            // 
            this.Saida.DataPropertyName = "VL_SAIDA";
            this.Saida.HeaderText = "Saída";
            this.Saida.Name = "Saida";
            this.Saida.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "VL_SALDO";
            this.Saldo.HeaderText = "Saldo Final";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoFinal.Location = new System.Drawing.Point(592, 385);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.ReadOnly = true;
            this.txtSaldoFinal.Size = new System.Drawing.Size(96, 20);
            this.txtSaldoFinal.TabIndex = 4;
            this.txtSaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saldo final";
            // 
            // txtFkConta
            // 
            this.txtFkConta.Location = new System.Drawing.Point(13, 126);
            this.txtFkConta.Name = "txtFkConta";
            this.txtFkConta.Size = new System.Drawing.Size(70, 20);
            this.txtFkConta.TabIndex = 2;
            this.txtFkConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFkConta_KeyDown);
            this.txtFkConta.Leave += new System.EventHandler(this.txtFkConta_Leave);
            // 
            // txtDsConta
            // 
            this.txtDsConta.Enabled = false;
            this.txtDsConta.Location = new System.Drawing.Point(119, 126);
            this.txtDsConta.Name = "txtDsConta";
            this.txtDsConta.Size = new System.Drawing.Size(232, 20);
            this.txtDsConta.TabIndex = 39;
            // 
            // btnPesquisarConta
            // 
            this.btnPesquisarConta.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarConta.Image")));
            this.btnPesquisarConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarConta.Location = new System.Drawing.Point(83, 124);
            this.btnPesquisarConta.Name = "btnPesquisarConta";
            this.btnPesquisarConta.Size = new System.Drawing.Size(30, 22);
            this.btnPesquisarConta.TabIndex = 38;
            this.btnPesquisarConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarConta.UseVisualStyleBackColor = true;
            this.btnPesquisarConta.Click += new System.EventHandler(this.btnPesquisarConta_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Conta";
            // 
            // txtFkSegmento
            // 
            this.txtFkSegmento.Location = new System.Drawing.Point(13, 168);
            this.txtFkSegmento.Name = "txtFkSegmento";
            this.txtFkSegmento.Size = new System.Drawing.Size(70, 20);
            this.txtFkSegmento.TabIndex = 3;
            this.txtFkSegmento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFkSegmento_KeyDown);
            this.txtFkSegmento.Leave += new System.EventHandler(this.txtFkSegmento_Leave);
            // 
            // txtDsSegmento
            // 
            this.txtDsSegmento.Enabled = false;
            this.txtDsSegmento.Location = new System.Drawing.Point(119, 168);
            this.txtDsSegmento.Name = "txtDsSegmento";
            this.txtDsSegmento.Size = new System.Drawing.Size(232, 20);
            this.txtDsSegmento.TabIndex = 43;
            // 
            // btnPesquisarSegmento
            // 
            this.btnPesquisarSegmento.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarSegmento.Image")));
            this.btnPesquisarSegmento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarSegmento.Location = new System.Drawing.Point(83, 168);
            this.btnPesquisarSegmento.Name = "btnPesquisarSegmento";
            this.btnPesquisarSegmento.Size = new System.Drawing.Size(30, 22);
            this.btnPesquisarSegmento.TabIndex = 42;
            this.btnPesquisarSegmento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarSegmento.UseVisualStyleBackColor = true;
            this.btnPesquisarSegmento.Click += new System.EventHandler(this.btnPesquisarSegmento_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Segmento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Dt.Movimento de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Dt.Movimento até";
            // 
            // dtpDtMovtoAte
            // 
            this.dtpDtMovtoAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtMovtoAte.Location = new System.Drawing.Point(13, 80);
            this.dtpDtMovtoAte.Name = "dtpDtMovtoAte";
            this.dtpDtMovtoAte.Size = new System.Drawing.Size(111, 20);
            this.dtpDtMovtoAte.TabIndex = 1;
            // 
            // dtpDtMovtoDe
            // 
            this.dtpDtMovtoDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtMovtoDe.Location = new System.Drawing.Point(13, 34);
            this.dtpDtMovtoDe.Name = "dtpDtMovtoDe";
            this.dtpDtMovtoDe.Size = new System.Drawing.Size(111, 20);
            this.dtpDtMovtoDe.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTpOperacao);
            this.groupBox2.Location = new System.Drawing.Point(15, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 49);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Operação";
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
            // txtTotalDebito
            // 
            this.txtTotalDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDebito.Location = new System.Drawing.Point(249, 385);
            this.txtTotalDebito.Name = "txtTotalDebito";
            this.txtTotalDebito.ReadOnly = true;
            this.txtTotalDebito.Size = new System.Drawing.Size(96, 20);
            this.txtTotalDebito.TabIndex = 15;
            this.txtTotalDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total débito";
            // 
            // txtTotalCredito
            // 
            this.txtTotalCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCredito.Location = new System.Drawing.Point(424, 385);
            this.txtTotalCredito.Name = "txtTotalCredito";
            this.txtTotalCredito.ReadOnly = true;
            this.txtTotalCredito.Size = new System.Drawing.Size(96, 20);
            this.txtTotalCredito.TabIndex = 19;
            this.txtTotalCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Crédito";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoInicial.Location = new System.Drawing.Point(75, 385);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.ReadOnly = true;
            this.txtSaldoInicial.Size = new System.Drawing.Size(99, 20);
            this.txtSaldoInicial.TabIndex = 20;
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Saldo inicial";
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
            this.toolStripSeparator1,
            this.btnFiltrar,
            this.btnBuscar,
            this.btnRemoverFiltro,
            this.btnExportar,
            this.toolStripSeparator2,
            this.btnImprimir,
            this.btnExcluir,
            this.btnAlterar,
            this.btnInserir,
            this.toolStripLabel3,
            this.toolStripLabel2,
            this.toolStripLabel1});
            this.toolMenu.Location = new System.Drawing.Point(4, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(469, 34);
            this.toolMenu.TabIndex = 22;
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
            this.btnAtualizar.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(24, 31);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 31);
            this.btnBuscar.Text = "Filtrar por ID";
            this.btnBuscar.Visible = false;
            // 
            // btnRemoverFiltro
            // 
            this.btnRemoverFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoverFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverFiltro.Image")));
            this.btnRemoverFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoverFiltro.Name = "btnRemoverFiltro";
            this.btnRemoverFiltro.Size = new System.Drawing.Size(24, 31);
            this.btnRemoverFiltro.Text = "Remover Filtro";
            this.btnRemoverFiltro.Visible = false;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
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
            this.btnImprimirPadrao.Size = new System.Drawing.Size(111, 22);
            this.btnImprimirPadrao.Text = "Padrão";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 31);
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(66, 31);
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.Visible = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 31);
            this.btnInserir.Text = "&Incluir";
            this.btnInserir.Visible = false;
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
            // frmRelFluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Name = "frmRelFluxoDeCaixa";
            this.Text = "Relatório de Fluxo de Caixa";
            this.tbcRelatorio.ResumeLayout(false);
            this.tbpOpcoes.ResumeLayout(false);
            this.tbpOpcoes.PerformLayout();
            this.tbpDados.ResumeLayout(false);
            this.tbpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoDeCaixa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFluxoDeCaixa;
        private System.Windows.Forms.TextBox txtSaldoFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFkConta;
        private System.Windows.Forms.TextBox txtDsConta;
        protected System.Windows.Forms.Button btnPesquisarConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFkSegmento;
        private System.Windows.Forms.TextBox txtDsSegmento;
        protected System.Windows.Forms.Button btnPesquisarSegmento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDtMovtoAte;
        private System.Windows.Forms.DateTimePicker dtpDtMovtoDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTpOperacao;
        private System.Windows.Forms.TextBox txtTotalCredito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalDebito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Histórico;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnRemoverFiltro;
        private System.Windows.Forms.ToolStripSplitButton btnExportar;
        private System.Windows.Forms.ToolStripMenuItem btnExportarXls;
        private System.Windows.Forms.ToolStripMenuItem btnExportarPdf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem btnImprimirPadrao;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}
