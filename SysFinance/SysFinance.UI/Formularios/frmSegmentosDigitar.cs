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
    public partial class frmSegmentosDigitar : SysFinance.UI.frmDigitar
    {

        SegmentoBLL obj = new SegmentoBLL();
        SegmentoDTO segmento = new SegmentoDTO();
        AcaoSql acaoSelecionada;
        int id;

        public frmSegmentosDigitar(AcaoSql acao, SegmentoDTO segmento)
        {
            InitializeComponent();

            acaoSelecionada = acao;

            if (acao == AcaoSql.Incluir)
            {
                this.Text = "Inserir Segmento";
            } 

            else if (acao == AcaoSql.Alterar)
            {
                this.Text = "Alterar segmento";
                txtDsSegmento.Text = segmento.DsSegmento;
                this.id = segmento.IdSegmento;
            }

            else if (acao == AcaoSql.Consultar)
            {
                this.Text = "Consultar segmento";
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!FuncoesBasicas.VerifObrigatorio(this, "txtDsSegmento"))
            {
                return;
            }

            if (!obj.verifCampo(txtDsSegmento.Text.Trim()))
            {
                FuncoesBasicas.Mens("Segmento já existe, não é possível cadastrá-lo novamente", "SysFinance");
                return;
            }

            segmento.DsSegmento = txtDsSegmento.Text;

            if (acaoSelecionada.Equals(AcaoSql.Incluir))
            {
                 obj.Incluir(segmento);
            }
            else if (acaoSelecionada.Equals(AcaoSql.Alterar))
            {
                segmento.IdSegmento = this.id;
                obj.Alterar(segmento);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
