namespace SysFinance.UI.Formularios
{
    partial class frmUsuariosConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosConsultar));
            this.label1 = new System.Windows.Forms.Label();
            this.cboTgUsuario = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Máquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnDesabilitarAtivar = new System.Windows.Forms.ToolStripButton();
            this.btnTrocarSenha = new System.Windows.Forms.ToolStripButton();
            this.btnConfigurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.toolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Status";
            // 
            // cboTgUsuario
            // 
            this.cboTgUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTgUsuario.FormattingEnabled = true;
            this.cboTgUsuario.Items.AddRange(new object[] {
            "0=Ativos",
            "1=Inativos",
            "T=Todos"});
            this.cboTgUsuario.Location = new System.Drawing.Point(3, 51);
            this.cboTgUsuario.Name = "cboTgUsuario";
            this.cboTgUsuario.Size = new System.Drawing.Size(112, 21);
            this.cboTgUsuario.TabIndex = 48;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(532, 46);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 26);
            this.btnConsultar.TabIndex = 47;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Login,
            this.Email,
            this.Máquina,
            this.Inativo,
            this.Senha});
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 78);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(617, 359);
            this.dgvUsuarios.TabIndex = 9;
            this.dgvUsuarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUsuarios_MouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PK_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 65;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "DS_NOME";
            this.Nome.HeaderText = "Nome do Usuário";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "DS_LOGIN";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "DS_EMAIL";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Máquina
            // 
            this.Máquina.DataPropertyName = "DS_NOMEMAQUINA";
            this.Máquina.HeaderText = "Máquina";
            this.Máquina.Name = "Máquina";
            this.Máquina.ReadOnly = true;
            this.Máquina.Width = 120;
            // 
            // Inativo
            // 
            this.Inativo.DataPropertyName = "TG_INATIVO";
            this.Inativo.HeaderText = "Ativo/Inativo";
            this.Inativo.Name = "Inativo";
            this.Inativo.ReadOnly = true;
            this.Inativo.Visible = false;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "DS_SENHA";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
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
            this.btnDesabilitarAtivar,
            this.btnTrocarSenha,
            this.btnConfigurar,
            this.toolStripLabel1,
            this.toolStripLabel3,
            this.toolStripLabel2});
            this.toolMenu.Location = new System.Drawing.Point(-1, 1);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(631, 34);
            this.toolMenu.TabIndex = 3;
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
            // btnDesabilitarAtivar
            // 
            this.btnDesabilitarAtivar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesabilitarAtivar.Image")));
            this.btnDesabilitarAtivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDesabilitarAtivar.Name = "btnDesabilitarAtivar";
            this.btnDesabilitarAtivar.Size = new System.Drawing.Size(24, 31);
            this.btnDesabilitarAtivar.ToolTipText = "Ativar/Desativar";
            this.btnDesabilitarAtivar.Click += new System.EventHandler(this.btnDesabilitarAtivar_Click);
            // 
            // btnTrocarSenha
            // 
            this.btnTrocarSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocarSenha.Image")));
            this.btnTrocarSenha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrocarSenha.Name = "btnTrocarSenha";
            this.btnTrocarSenha.Size = new System.Drawing.Size(24, 31);
            this.btnTrocarSenha.ToolTipText = "Trocar Senha";
            this.btnTrocarSenha.Click += new System.EventHandler(this.btnTrocarSenha_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfigurar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigurar.Image")));
            this.btnConfigurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(24, 31);
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.ToolTipText = "Configuração de acesso";
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 31);
            this.toolStripLabel1.Text = "  ";
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
            // frmUsuariosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTgUsuario);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.toolMenu);
            this.Name = "frmUsuariosConsultar";
            this.Text = "Consulta de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripButton btnTrocarSenha;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        protected System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboTgUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnConfigurar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton btnDesabilitarAtivar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Máquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
    }
}
