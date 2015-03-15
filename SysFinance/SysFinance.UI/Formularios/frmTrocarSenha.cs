using SysFinance.BLL;
using SysFinance.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysFinance.UI.Formularios
{
    public partial class frmTrocarSenha : SysFinance.UI.frmDigitar
    {
        UsuarioBLL obj = new UsuarioBLL();
        UsuarioDTO usuario = new UsuarioDTO();

        public frmTrocarSenha(UsuarioDTO usuario)
        {
            InitializeComponent();

            txtPkId.Text = usuario.IdUsuario.ToString();
            txtDsNome.Text = usuario.DsNome;

            //txtPkId.Enabled = false;
            //txtDsNome.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (!FuncoesBasicas.VerifObrigatorio(this, "txtDsSenha,txtConfirmaSenha"))
            {
                return;
            }

            if (txtDsSenha.Text != txtConfirmaSenha.Text)
            {
                FuncoesBasicas.Mens("Senhas não conferem!", "SysFinance");
                txtConfirmaSenha.Focus();
            }
            else
            {
                usuario.IdUsuario = Convert.ToInt32(this.txtPkId.Text);
                usuario.DsSenha = txtDsSenha.Text.Trim();

                obj.TrocarSenha(usuario);
                this.Close();
            }
        }
    }
}
