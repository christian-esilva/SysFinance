namespace SysFinance.UI.Base
{
    partial class frmBaseRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseRelatorio));
            this.tbcRelatorio = new System.Windows.Forms.TabControl();
            this.tbpOpcoes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.tbpDados = new System.Windows.Forms.TabPage();
            this.lblExibido = new System.Windows.Forms.Label();
            this.tbcRelatorio.SuspendLayout();
            this.tbpOpcoes.SuspendLayout();
            this.tbpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRelatorio
            // 
            this.tbcRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcRelatorio.Controls.Add(this.tbpOpcoes);
            this.tbcRelatorio.Controls.Add(this.tbpDados);
            this.tbcRelatorio.Location = new System.Drawing.Point(2, 2);
            this.tbcRelatorio.Name = "tbcRelatorio";
            this.tbcRelatorio.SelectedIndex = 0;
            this.tbcRelatorio.Size = new System.Drawing.Size(624, 437);
            this.tbcRelatorio.TabIndex = 0;
            // 
            // tbpOpcoes
            // 
            this.tbpOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.tbpOpcoes.Controls.Add(this.panel1);
            this.tbpOpcoes.Controls.Add(this.btnCancelar);
            this.tbpOpcoes.Controls.Add(this.btnProsseguir);
            this.tbpOpcoes.Location = new System.Drawing.Point(4, 22);
            this.tbpOpcoes.Name = "tbpOpcoes";
            this.tbpOpcoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOpcoes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbpOpcoes.Size = new System.Drawing.Size(616, 411);
            this.tbpOpcoes.TabIndex = 0;
            this.tbpOpcoes.Text = "Opções do relatório";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-3, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 1);
            this.panel1.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(521, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProsseguir.Image = ((System.Drawing.Image)(resources.GetObject("btnProsseguir.Image")));
            this.btnProsseguir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProsseguir.Location = new System.Drawing.Point(6, 365);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(92, 40);
            this.btnProsseguir.TabIndex = 6;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProsseguir.UseVisualStyleBackColor = true;
            // 
            // tbpDados
            // 
            this.tbpDados.BackColor = System.Drawing.Color.Transparent;
            this.tbpDados.Controls.Add(this.lblExibido);
            this.tbpDados.Location = new System.Drawing.Point(4, 22);
            this.tbpDados.Name = "tbpDados";
            this.tbpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDados.Size = new System.Drawing.Size(616, 411);
            this.tbpDados.TabIndex = 1;
            this.tbpDados.Text = "Resultado (Dados do relatório)";
            // 
            // lblExibido
            // 
            this.lblExibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExibido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblExibido.Location = new System.Drawing.Point(410, 3);
            this.lblExibido.Name = "lblExibido";
            this.lblExibido.Size = new System.Drawing.Size(196, 19);
            this.lblExibido.TabIndex = 13;
            this.lblExibido.Text = "Data Exibição";
            // 
            // frmBaseRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tbcRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmBaseRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseRelatorio";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sair_KeyDown);
            this.tbcRelatorio.ResumeLayout(false);
            this.tbpOpcoes.ResumeLayout(false);
            this.tbpDados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl tbcRelatorio;
        protected System.Windows.Forms.TabPage tbpOpcoes;
        protected System.Windows.Forms.TabPage tbpDados;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnProsseguir;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label lblExibido;
    }
}