namespace SysFinance.UI.Base
{
    partial class frmBaseSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseSelecionar));
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.chkBuscarNoMeio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(-2, 5);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(116, 13);
            this.lblBusca.TabIndex = 0;
            this.lblBusca.Text = "Consultar por (CAMPO)";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(1, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(398, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProsseguir.Image = ((System.Drawing.Image)(resources.GetObject("btnProsseguir.Image")));
            this.btnProsseguir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProsseguir.Location = new System.Drawing.Point(543, 23);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(78, 25);
            this.btnProsseguir.TabIndex = 5;
            this.btnProsseguir.Text = "Buscar";
            this.btnProsseguir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProsseguir.UseVisualStyleBackColor = true;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(441, 347);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 32);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(531, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 32);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(1, 54);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(620, 290);
            this.dgvDados.TabIndex = 19;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // chkBuscarNoMeio
            // 
            this.chkBuscarNoMeio.AutoSize = true;
            this.chkBuscarNoMeio.Location = new System.Drawing.Point(221, 5);
            this.chkBuscarNoMeio.Name = "chkBuscarNoMeio";
            this.chkBuscarNoMeio.Size = new System.Drawing.Size(178, 17);
            this.chkBuscarNoMeio.TabIndex = 26;
            this.chkBuscarNoMeio.Text = "Buscar palavra no meio do texto";
            this.chkBuscarNoMeio.UseVisualStyleBackColor = true;
            // 
            // frmBaseSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 381);
            this.ControlBox = false;
            this.Controls.Add(this.chkBuscarNoMeio);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmBaseSelecionar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar dados";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseSelecionar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusca;
        protected System.Windows.Forms.Button btnProsseguir;
        protected System.Windows.Forms.Button btnOk;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.CheckBox chkBuscarNoMeio;
    }
}