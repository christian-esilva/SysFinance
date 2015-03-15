namespace SysFinance.UI
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuSuperior = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSegmentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLancamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExtratos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 293);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mnuSuperior
            // 
            this.mnuSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuSuperior.AutoSize = false;
            this.mnuSuperior.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuCadastros,
            this.mnuMovimentos,
            this.mnuRelatorios,
            this.mnuAjuda});
            this.mnuSuperior.Location = new System.Drawing.Point(0, 0);
            this.mnuSuperior.Name = "mnuSuperior";
            this.mnuSuperior.Size = new System.Drawing.Size(723, 24);
            this.mnuSuperior.TabIndex = 3;
            this.mnuSuperior.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogoff,
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mnuLogoff
            // 
            this.mnuLogoff.Name = "mnuLogoff";
            this.mnuLogoff.Size = new System.Drawing.Size(109, 22);
            this.mnuLogoff.Text = "Logoff";
            this.mnuLogoff.Click += new System.EventHandler(this.mnuLogoff_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(109, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContas,
            this.mnuSegmentos,
            this.mnuUsuarios});
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastros.Text = "Cadastros";
            // 
            // mnuContas
            // 
            this.mnuContas.Name = "mnuContas";
            this.mnuContas.Size = new System.Drawing.Size(133, 22);
            this.mnuContas.Text = "Contas";
            this.mnuContas.Click += new System.EventHandler(this.mnuContas_Click);
            // 
            // mnuSegmentos
            // 
            this.mnuSegmentos.Name = "mnuSegmentos";
            this.mnuSegmentos.Size = new System.Drawing.Size(133, 22);
            this.mnuSegmentos.Text = "Segmentos";
            this.mnuSegmentos.Click += new System.EventHandler(this.mnuSegmentos_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(133, 22);
            this.mnuUsuarios.Text = "Usuários";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuMovimentos
            // 
            this.mnuMovimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLancamentos});
            this.mnuMovimentos.Name = "mnuMovimentos";
            this.mnuMovimentos.Size = new System.Drawing.Size(86, 20);
            this.mnuMovimentos.Text = "Movimentos";
            // 
            // mnuLancamentos
            // 
            this.mnuLancamentos.Name = "mnuLancamentos";
            this.mnuLancamentos.Size = new System.Drawing.Size(145, 22);
            this.mnuLancamentos.Text = "Lançamentos";
            this.mnuLancamentos.Click += new System.EventHandler(this.mnuLancamentos_Click);
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExtratos,
            this.mnuFluxoDeCaixa});
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mnuRelatorios.Text = "Relatórios";
            // 
            // mnuFluxoDeCaixa
            // 
            this.mnuFluxoDeCaixa.Name = "mnuFluxoDeCaixa";
            this.mnuFluxoDeCaixa.Size = new System.Drawing.Size(152, 22);
            this.mnuFluxoDeCaixa.Text = "Fluxo de Caixa";
            this.mnuFluxoDeCaixa.Click += new System.EventHandler(this.mnuFluxoDeCaixa_Click);
            // 
            // mnuExtratos
            // 
            this.mnuExtratos.Name = "mnuExtratos";
            this.mnuExtratos.Size = new System.Drawing.Size(152, 22);
            this.mnuExtratos.Text = "Extratos";
            this.mnuExtratos.Click += new System.EventHandler(this.mnuExtratos_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVerAjuda,
            this.toolStripSeparator2,
            this.mnuSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(50, 20);
            this.mnuAjuda.Text = "Ajuda";
            // 
            // mnuVerAjuda
            // 
            this.mnuVerAjuda.Name = "mnuVerAjuda";
            this.mnuVerAjuda.Size = new System.Drawing.Size(175, 22);
            this.mnuVerAjuda.Text = "Ver ajuda";
            this.mnuVerAjuda.Click += new System.EventHandler(this.mnuVerAjuda_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(175, 22);
            this.mnuSobre.Text = "Sobre o SysFinance";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(723, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(12, 528);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(151, 13);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.BackColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(403, 528);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(128, 13);
            this.lblData.TabIndex = 10;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(557, 528);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(143, 13);
            this.lblHora.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(724, 542);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(740, 580);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysFinance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pressionar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuSuperior.ResumeLayout(false);
            this.mnuSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mnuSuperior;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnuContas;
        private System.Windows.Forms.ToolStripMenuItem mnuSegmentos;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuMovimentos;
        private System.Windows.Forms.ToolStripMenuItem mnuLancamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mnuFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem mnuExtratos;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuVerAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuLogoff;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
    }
}

