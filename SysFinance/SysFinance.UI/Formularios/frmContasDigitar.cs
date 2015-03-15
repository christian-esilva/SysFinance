using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysFinance.BLL;
using SysFinance.DTO;

namespace SysFinance.UI.Formularios
{
    public partial class frmContasDigitar : SysFinance.UI.frmDigitar
    {
        
        ContaBLL obj = new ContaBLL();
        ContaDTO conta = new ContaDTO();
        AcaoSql acaoSelecionada;
        int idConta, idUser;

        public frmContasDigitar(AcaoSql acao, ContaDTO conta, int idUser)
        {
            InitializeComponent();

            acaoSelecionada = acao;
            this.idUser = idUser;
            
            if (acao == AcaoSql.Incluir)
            {
                this.Text = "Inserir conta";
            }
            else if (acao == AcaoSql.Alterar)
            {
                this.Text = "Alterar conta";
                txtDsCodigo.Text = conta.DsCodigo;
                txtDsCodigo.Enabled = false;
                txtDsConta.Text = conta.DsConta;
                this.idConta = conta.IdConta;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (!FuncoesBasicas.VerifObrigatorio(this,"txtDsCodigo,txtDsConta"))
            {
                return;
            }

            conta.DsCodigo  = txtDsCodigo.Text;
            conta.DsConta   = txtDsConta.Text;
            conta.IdUsuario = idUser;

            if (acaoSelecionada.Equals(AcaoSql.Incluir))
            {
                if (!obj.verifCampo(txtDsCodigo.Text.Trim(),idUser))
                {
                    FuncoesBasicas.Mens("Código de conta existente, não é possível cadastrá-lo novamente", "SysFinance");
                    return;
                }
                else
                {
                    obj.Incluir(conta);
                }
                
            }
            else if (acaoSelecionada.Equals(AcaoSql.Alterar))
            {
                conta.IdConta = this.idConta;
                obj.Alterar(conta);
            }

            this.Close();
        }

        private void Digitar(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127)
            {
                e.Handled = true;
            }
        }
    }
}
