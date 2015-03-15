using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysFinance.DTO;
using SysFinance.BLL;

namespace SysFinance.UI.Formularios
{
    public partial class frmUsuariosDigitar : SysFinance.UI.frmDigitar
    {

        UsuarioBLL obj = new UsuarioBLL();
        UsuarioDTO usuario = new UsuarioDTO();
        AcaoSql acaoSelecionada;
        int id;
        string loginOld;

        public frmUsuariosDigitar(AcaoSql acao, UsuarioDTO usuario)
        {
            InitializeComponent();
            acaoSelecionada = acao;

            if (acao == AcaoSql.Incluir)
            {
                this.Text = "Inserir usuário";
            }
            else if (acao == AcaoSql.Alterar)
            {
                this.Text = "Alterar usuário";
                txtDsNome.Text = usuario.DsNome;
                txtDsEmail.Text = usuario.DsEmail;
                txtDsLogin.Text = usuario.DsLogin;
                loginOld = txtDsLogin.Text.Trim();

                txtDsSenha.Text = usuario.DsSenha;
                txtConfirmaSenha.Text = usuario.DsSenha;
                txtDsSenha.Enabled = false;
                txtConfirmaSenha.Enabled = false;

                this.id = usuario.IdUsuario;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (!FuncoesBasicas.VerifObrigatorio(this, "txtDsNome,txtDsLogin,txtDsSenha,txtConfirmaSenha"))
            {
                return;
            }

            usuario.IdUsuario = this.id;
            usuario.DsNome = txtDsNome.Text;
            usuario.DsLogin = txtDsLogin.Text;
            usuario.DsEmail = txtDsEmail.Text;
            usuario.DsSenha = txtDsSenha.Text;
            usuario.DsNomeMaquina = "";
            usuario.TgInativo = 0;

            if (!loginOld.Equals(usuario.DsLogin.Trim())){

                if (!obj.verifCampo(txtDsLogin.Text.Trim()))
                {
                    FuncoesBasicas.Mens("Login já existe, não é possível cadastrá-lo novamente", "SysFinance");
                    txtDsLogin.Focus();
                    return;
                }                  
            }

            if (acaoSelecionada.Equals(AcaoSql.Incluir))
            {
                if (txtDsSenha.Text != txtConfirmaSenha.Text)
                {
                    FuncoesBasicas.Mens("Senhas não conferem!", "SysFinance");
                    txtConfirmaSenha.Focus();
                    return;
                }

                obj.Incluir(usuario);
                    
                FuncoesBasicas.Mens("Atenção, o novo usuário não possui nenhum direito no sistema, favor adicioná-los.","SysFinance");
            }
            else if (acaoSelecionada.Equals(AcaoSql.Alterar))
            {
                usuario.IdUsuario = this.id;
                obj.Alterar(usuario);
            }

            this.Close();
        }


    }
}
