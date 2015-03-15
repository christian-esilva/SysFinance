using SysFinance.BLL;
using SysFinance.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SysFinance.UI.Formularios
{
    public partial class frmConfigurarAcesso : SysFinance.UI.frmDigitar
    {
        UsuarioDTO usuario = new UsuarioDTO();
        DireitoAcessoDTO acesso = new DireitoAcessoDTO();
        DireitoAcessoBLL obj = new DireitoAcessoBLL();

        public frmConfigurarAcesso(UsuarioDTO usuario)
        {
            InitializeComponent();

            txtFkUsuario.Text = usuario.IdUsuario.ToString();
            txtDsUsuario.Text = usuario.DsNome;

            CarregarDireitos(usuario.IdUsuario);
        }

        public void CarregarDireitos(int codUsuario) {
            SqlDataReader direitos = obj.CarregarDireitos(codUsuario);

            if (direitos.Read())
            {
                chkTgUsuario.Checked = Convert.ToInt32(direitos[2]) > 0 ? true : false;
                chkTgSegmento.Checked = Convert.ToInt32(direitos[3]) > 0 ? true : false;
                chkTgContas.Checked = Convert.ToInt32(direitos[4]) > 0 ? true : false;
                chkTgLancto.Checked = Convert.ToInt32(direitos[5]) > 0 ? true : false;
                chkFluxoCaixa.Checked = Convert.ToInt32(direitos[6]) > 0 ? true : false;
                chkExtratoContas.Checked = Convert.ToInt32(direitos[7]) > 0 ? true : false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            acesso.FkUsuario = Convert.ToInt32(txtFkUsuario.Text);
            acesso.TgConta = chkTgContas.Checked ? 1 : 0;
            acesso.TgSegmento = chkTgSegmento.Checked ? 1 : 0;
            acesso.TgUsuario=chkTgUsuario.Checked ? 1: 0;
            acesso.TgLancamento = chkTgLancto.Checked ? 1 : 0;
            acesso.TgExtratoConta = chkExtratoContas.Checked ? 1 : 0;
            acesso.TgFluxoCaixa = chkFluxoCaixa.Checked ? 1 : 0;

            obj.AtualizarDireitos(acesso);

            FuncoesBasicas.Mens("Direitos de acesso aplicados. \nFavor reiniciar o sistema para que as alterações se tornem válidas.", "SysFinance");
            this.Close();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            chkTgUsuario.Checked = chkTgUsuario.Checked ? false : true;
            chkTgSegmento.Checked = chkTgSegmento.Checked ? false : true;
            chkTgContas.Checked = chkTgContas.Checked ? false : true;
            chkTgLancto.Checked = chkTgLancto.Checked ? false : true;
            chkFluxoCaixa.Checked = chkFluxoCaixa.Checked ? false : true;
            chkExtratoContas.Checked = chkExtratoContas.Checked ? false : true;
        }
    }
}
