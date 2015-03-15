using SysFinance.BLL;
using SysFinance.DTO;
using SysFinance.UI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace SysFinance.UI.Formularios
{
    public partial class frmLancamentosDigitar : SysFinance.UI.frmDigitar
    {
        LanctoFinanceiroBLL obj = new LanctoFinanceiroBLL();
        LanctoFinanceiroDTO lancto = new LanctoFinanceiroDTO();
        SelecaoDadosBLL selDados = new SelecaoDadosBLL();

        AcaoSql acaoSelecionada;
        int idUser;
        int idLancto;

        public frmLancamentosDigitar(AcaoSql acao, LanctoFinanceiroDTO lancto, int idUser)
        {
            InitializeComponent();
            acaoSelecionada = acao;

            this.idUser = idUser;
            FuncoesBasicas.soNumeros(txtFkSegmento);

            if (acao == AcaoSql.Incluir)
            {
                this.Text = "Inserir lançamento";
            }
            else if (acao == AcaoSql.Alterar)
            {
                this.Text = "Alterar lançamento";

                this.idLancto = lancto.PkId;
                dtpDtLancto.Text = Convert.ToString(lancto.DtLancto);
                txtVlLancto.Text = Convert.ToString(lancto.VlLancto);
                FuncoesBasicas.RetornarMascara(txtVlLancto,null);
                txtFkConta.Text = lancto.FkConta;
                validarConta(txtFkConta.Text.Trim());
                txtFkSegmento.Text = Convert.ToString(lancto.FkSegmento);
                validarSegmento(txtFkSegmento.Text.Trim());
                txtDsLancto.Text = lancto.DsLancto;
                txtDsObs.Text = lancto.DsObs;

                if (lancto.TpOperacao == 'C') {
                    rdbCredito.Checked = true;
                }
                else if (lancto.TpOperacao == 'D') {
                    rdbDebito.Checked = true;
                }
            }

            FuncoesBasicas.AplicarEventos(txtVlLancto);
        }

        private void Digitar(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127)
            {
                e.Handled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!FuncoesBasicas.VerifObrigatorio(this, "txtDsLancto,txtVlLancto,txtFkConta,txtFkSegmento"))
            {
                return;
            }

            lancto.PkId = this.idLancto;
            lancto.FkUsuario = idUser;
            lancto.DtLancto = dtpDtLancto.Value;
            lancto.VlLancto = Convert.ToDouble(txtVlLancto.Text);
            lancto.FkConta = txtFkConta.Text.Trim();
            lancto.FkSegmento = Convert.ToInt32(txtFkSegmento.Text);
            lancto.DsLancto = txtDsLancto.Text.Trim();
            lancto.DsObs     = txtDsObs.Text.Trim();

            if (rdbDebito.Checked){
                lancto.TpOperacao = 'D';
            } 
            else if (rdbCredito.Checked)
            {
                lancto.TpOperacao = 'C';
            }

            if (acaoSelecionada.Equals(AcaoSql.Incluir))
            {
                obj.Incluir(lancto);
            }
            else if (acaoSelecionada.Equals(AcaoSql.Alterar))
            {
                obj.Alterar(lancto);
            }

            this.Close();
        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDebito.Checked) 
            {
                rdbCredito.Checked = false;
            }
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCredito.Checked)
            {
                rdbDebito.Checked = false;
            }
        }

        private void frmLancamentosDigitar_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisarConta_Click(object sender, EventArgs e)
        {
            frmBaseSelecionar selContas = new frmBaseSelecionar("CONTAS", "TB_CONTAS", "Conta", "DS_CONTA", idUser);
            FuncoesBasicas.chamaForm(selContas, "modal");

            txtFkConta.Text = selContas.ValorRetorno.ToString();

            validarConta(txtFkConta.Text.Trim());
        }

        public void validarConta(string codigo = "")
        {

            if (!codigo.Equals(""))
            {
                string valorRetorno = selDados.Validar(txtFkConta.Text, "TB_CONTAS", "DS_CONTA", "DS_CODIGO", idUser);

                if (!valorRetorno.Equals(""))
                {
                    txtDsConta.Text = valorRetorno;
                }
                else
                {
                    FuncoesBasicas.Mens("Código inválido, favor informar código existente");
                    txtFkConta.Text = "";
                    txtDsConta.Text = "";
                    txtFkConta.Focus();
                }
            }
            else
            {
                txtDsConta.Text = "";
            }
        }

        private void btnPesquisarSeg_Click(object sender, EventArgs e)
        {
            frmBaseSelecionar selContas = new frmBaseSelecionar("SEGMENTOS", "TB_SEGMENTOS", "Segmento", "DS_SEGMENTO");
            FuncoesBasicas.chamaForm(selContas, "modal");

            txtFkSegmento.Text = selContas.ValorRetorno.ToString();

            validarSegmento(txtFkSegmento.Text.Trim());
        }

        public void validarSegmento(string codigo = "")
        {

            if (!codigo.Equals(""))
            {
                string valorRetorno = selDados.Validar(codigo, "TB_SEGMENTOS", "DS_SEGMENTO");

                if (!valorRetorno.Equals(""))
                {
                    txtDsSegmento.Text = valorRetorno;
                }
                else
                {
                    FuncoesBasicas.Mens("Código inválido, favor informar código existente");
                    txtFkSegmento.Text = "";
                    txtDsSegmento.Text = "";
                    txtFkSegmento.Focus();
                }
            }
            else
            {
                txtDsSegmento.Text = "";
            }
        }

        private void txtFkConta_KeyDown(object sender, KeyEventArgs e)
        {
            FuncoesBasicas.abrirBusca(sender, e, this.btnPesquisarConta);
        }

        private void txtFkConta_Leave(object sender, EventArgs e)
        {
            validarConta(txtFkConta.Text.Trim());
        }

        private void txtFkSegmento_KeyDown(object sender, KeyEventArgs e)
        {
            FuncoesBasicas.abrirBusca(sender, e, this.btnPesquisarSeg);
        }

        private void txtFkSegmento_Leave(object sender, EventArgs e)
        {
            validarSegmento(txtFkSegmento.Text.Trim());
        }
    }
}
