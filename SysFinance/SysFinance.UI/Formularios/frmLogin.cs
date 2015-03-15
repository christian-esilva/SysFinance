using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysFinance.BLL;
using SysFinance.DTO;
using SysFinance.UI.Formularios;

namespace SysFinance.UI
{
    public partial class frmLogin : SysFinance.UI.frmDigitar
    {

        UsuarioDTO usuario = new UsuarioDTO();
        UsuarioBLL obj = new UsuarioBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!FuncoesBasicas.StringVazia(txtDsLogin.Text))
            {
                FuncoesBasicas.Mens("Login não informado");
                txtDsLogin.Focus();
                return;
            }

            if (!FuncoesBasicas.StringVazia(txtSenha.Text)){
                FuncoesBasicas.Mens("Senha não informada");
                txtSenha.Focus();
                return;
            }

            usuario.DsLogin = txtDsLogin.Text;
            usuario.DsSenha = txtSenha.Text;

            try 
            {
                usuario = obj.AutenticaLogin(usuario);

                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(usuario);
                FuncoesBasicas.chamaForm(menuPrincipal);

                this.Visible = false;

                if (Convert.ToInt32(menuPrincipal.autoAjuda) == 0) {
                    frmAjuda ajuda = new frmAjuda(usuario.IdUsuario);
                    FuncoesBasicas.chamaForm(ajuda, "modal");
                }
            } catch (Exception) 
            {
                FuncoesBasicas.Mens("LOGIN INVÁLIDO \n\nConfira seus dados de login e tente novamente.", "SysFinance");

                txtDsLogin.Clear();
                txtSenha.Clear();
                txtDsLogin.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
