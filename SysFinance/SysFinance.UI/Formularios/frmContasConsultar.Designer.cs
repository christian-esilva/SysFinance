namespace SysFinance.UI.Formularios
{
    partial class frmContasConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasConsultar));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDsConta = new System.Windows.Forms.TextBox();
            this.txtFkConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.toolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(534, 52);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 26);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Código,
            this.Descrição});
            this.dgvContas.Location = new System.Drawing.Point(3, 82);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(619, 353);
            this.dgvContas.TabIndex = 3;
            this.dgvContas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvContas_MouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PK_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 70;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "DS_CODIGO";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 65;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "DS_CONTA";
            this.Descrição.HeaderText = "Descrição da Conta";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 375;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(95, 55);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 20);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDsConta
            // 
            this.txtDsConta.Enabled = false;
            this.txtDsConta.Location = new System.Drawing.Point(131, 56);
            this.txtDsConta.Name = "txtDsConta";
            this.txtDsConta.Size = new System.Drawing.Size(226, 20);
            this.txtDsConta.TabIndex = 15;
            // 
            // txtFkConta
            // 
            this.txtFkConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFkConta.Location = new System.Drawing.Point(3, 56);
            this.txtFkConta.Name = "txtFkConta";
            this.txtFkConta.Size = new System.Drawing.Size(91, 20);
            this.txtFkConta.TabIndex = 0;
            this.txtFkConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFkConta_KeyDown);
            this.txtFkConta.Leave += new System.EventHandler(this.txtFkConta_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Conta";
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
            this.toolMenu.Location = new System.Drawing.Point(-1, 1);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(627, 34);
            this.toolMenu.TabIndex = 11;
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
            // frmContasConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvContas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtDsConta);
            this.Controls.Add(this.txtFkConta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolMenu);
            this.Name = "frmContasConsultar";
            this.Text = "Consulta de Contas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvContas;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDsConta;
        private System.Windows.Forms.TextBox txtFkConta;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
    }
}
