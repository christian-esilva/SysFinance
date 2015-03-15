using SysFinance.DTO;
using SysFinance.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysFinance.UI.Base;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SysFinance.UI.Formularios
{
    public partial class frmLancamentosConsultar : SysFinance.UI.frmConsultar
    {
        LanctoFinanceiroBLL obj = new LanctoFinanceiroBLL();
        LanctoFinanceiroDTO lancto = new LanctoFinanceiroDTO();
        SelecaoDadosBLL selDados = new SelecaoDadosBLL();

        int idUser;

        public frmLancamentosConsultar(int idUser)
        {
            InitializeComponent();
            cmbTpOperacao.SelectedIndex = 0;

            this.idUser = idUser;

            dtpDtMovtoDe.Text = "01/" + dtpDtMovtoDe.Value.Date.Month + "/" + dtpDtMovtoDe.Value.Date.Year;

            FuncoesBasicas.soNumeros(txtFkSegmento);

            AtualizaGrade(idUser);
        }

        public DataTable AtualizaGrade(int idUser)
        {
            string query = "";

            if (!this.filtroId.Equals(""))
            {
                query += this.filtroId;
            }
            else {

                if (FuncoesBasicas.StringVazia(this.txtFkConta.Text))
                {
                    query += " AND FK_CONTA = '" + this.txtFkConta.Text + "'";
                }

                if (FuncoesBasicas.StringVazia(this.txtFkSegmento.Text))
                {
                    query += " AND FK_SEGMENTO = '" + this.txtFkSegmento.Text + "'";
                }

                Object selectedItem = cmbTpOperacao.SelectedItem;
                string condicao = selectedItem.ToString().Trim().Substring(0, 1);

                if (!condicao.Equals("T"))
                {
                    query += " AND TP_OPERACAO = '" + condicao + "'";
                }

                query += " AND DT_LANCTO >= CONVERT(DATETIME,'" + dtpDtMovtoDe.Value + "',103)";
                query += " AND DT_LANCTO <=  CONVERT(DATETIME,'" + dtpDtMovtoAte.Value + "',103)";
            
            }

            dgvLancamentos.DataSource = obj.CarregaGrade(idUser, query);

            return obj.CarregaGrade(idUser, query);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmLancamentosDigitar lanctoDigitar = new frmLancamentosDigitar(AcaoSql.Incluir, null, idUser);
            FuncoesBasicas.chamaForm(lanctoDigitar, "modal");
            AtualizaGrade(idUser);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!FuncoesBasicas.verifRegistros(dgvLancamentos))
            {
                FuncoesBasicas.Mens("Não existem dados a serem alterados", "SysFinance");
                return;
            }

            lancto.PkId = (Int32)dgvLancamentos.CurrentRow.Cells[0].Value;
            lancto.FkConta = (string)dgvLancamentos.CurrentRow.Cells[1].Value;
            lancto.FkSegmento = (Int32)dgvLancamentos.CurrentRow.Cells[2].Value;
            lancto.DtLancto = Convert.ToDateTime(dgvLancamentos.CurrentRow.Cells[3].Value);
            lancto.VlLancto = Convert.ToDouble(dgvLancamentos.CurrentRow.Cells[4].Value);
            lancto.TpOperacao = Convert.ToChar(dgvLancamentos.CurrentRow.Cells[5].Value);
            lancto.DsLancto = (string)dgvLancamentos.CurrentRow.Cells[6].Value;
            lancto.DsObs = (string)dgvLancamentos.CurrentRow.Cells[7].Value;
            lancto.FkUsuario = (Int32)dgvLancamentos.CurrentRow.Cells[8].Value;
           
            frmLancamentosDigitar lanctoDigitar = new frmLancamentosDigitar(AcaoSql.Alterar, lancto, idUser);
            FuncoesBasicas.chamaForm(lanctoDigitar, "modal");

            AtualizaGrade(idUser);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrade(idUser);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FuncoesBasicas.verifRegistros(dgvLancamentos))
                {
                    FuncoesBasicas.Mens("Não existem dados a serem deletados", "SysFinance");
                    return;
                }

                int codigo = Convert.ToInt32(dgvLancamentos.CurrentRow.Cells[0].Value);

                if (FuncoesBasicas.SimOuNao("Deseja excluir o lançamento selecionado " + codigo + "?", "SysFinance"))
                {

                    Int32 id = (Int32)dgvLancamentos.CurrentRow.Cells[0].Value;
                    obj.Excluir(id);

                    FuncoesBasicas.Mens("Registro excluído com sucesso.", "SysFinance");
                    AtualizaGrade(idUser);
                }
            }
            catch (Exception ex)
            {
                FuncoesBasicas.Mens("Não foi possível excluir." + ex, "SysFinance");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AtualizaGrade(idUser);
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

        private void txtFkSegmento_Leave(object sender, EventArgs e)
        {
            validarSegmento(txtFkSegmento.Text.Trim());
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

        private void txtFkConta_Leave(object sender, EventArgs e)
        {
            validarConta(txtFkConta.Text.Trim());
        }

        private void txtFkSegmento_KeyDown(object sender, KeyEventArgs e)
        {
            FuncoesBasicas.abrirBusca(sender, e, this.btnPesquisarSeg);
        }

        private void txtFkConta_KeyDown(object sender, KeyEventArgs e)
        {
            FuncoesBasicas.abrirBusca(sender, e, this.btnPesquisarConta);
        }

        private void dgvLancamentos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dgvLancamentos.HitTest(e.X, e.Y).RowIndex;

                m.MenuItems.Add(new MenuItem("Incluir", btnInserir_Click));
                m.MenuItems.Add(new MenuItem("Alterar", btnAlterar_Click));
                m.MenuItems.Add(new MenuItem("Excluir", btnExcluir_Click));
                m.Show(dgvLancamentos, new Point(e.X, e.Y));
            }
        }

        #region Gerar arquivo Xls
        private void btnExportarXls_Click(object sender, EventArgs e)
        {
            ExportToXls(AtualizaGrade(idUser));
        }

        public void ExportToXls(DataTable dt)
        {
            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo XLS";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "XLS File|.xls";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Rel_Lancto" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
            //Define a extensão padrão como .txt
            saveFileDialog1.DefaultExt = ".xls";
            //define o diretório padrão
            saveFileDialog1.InitialDirectory = @"c:\\";
            //restaura o diretorio atual antes de fechar a janela
            saveFileDialog1.RestoreDirectory = true;

            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = saveFileDialog1.ShowDialog();

            try
            {
                var excel = new Excel.Application { Visible = false };
                var misValue = System.Reflection.Missing.Value;
                var wb = excel.Workbooks.Add(misValue);

                Excel.Worksheet sh = wb.Sheets.Add();
                sh.Name = "Rel_Lanctos";
                sh.Cells[1, "A"].Value2 = "Relatório de Lançamentos - SysFinance";
                sh.Cells[2, "A"].Value2 = "Gerado em: " + System.DateTime.Now;
                sh.Cells[3, "A"].Value2 = "ID Lanc.";
                sh.Cells[3, "B"].Value2 = "Conta";
                sh.Cells[3, "C"].Value2 = "Data";
                sh.Cells[3, "D"].Value2 = "Valor R$";
                sh.Cells[3, "E"].Value2 = "Tipo";
                sh.Cells[3, "F"].Value2 = "Descrição";
                sh.Cells[3, "G"].Value2 = "Observação";
                sh.Cells[3, "H"].Value2 = "Cod. Usuário";
                sh.Cells[3, "I"].Value2 = "Segmento";

                /* Insert Rows */
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sh.Cells[i + 4, "A"].Value2 = dt.Rows[i][0];
                    sh.Cells[i + 4, "B"].Value2 += dt.Rows[i][1];
                    sh.Cells[i + 4, "C"].Value2 += dt.Rows[i][3];
                    sh.Cells[i + 4, "D"].Value2 += dt.Rows[i][4];
                    sh.Cells[i + 4, "E"].Value2 += dt.Rows[i][5];
                    sh.Cells[i + 4, "F"].Value2 += dt.Rows[i][6];
                    sh.Cells[i + 4, "G"].Value2 += dt.Rows[i][7];
                    sh.Cells[i + 4, "H"].Value2 += dt.Rows[i][8];
                    sh.Cells[i + 4, "I"].Value2 += dt.Rows[i][9];
                }

                wb.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                wb.Close(true);
                excel.Quit();
                FuncoesBasicas.Mens("Arquivo gerado!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
#endregion

        #region Gerar arquivo PDF
        public bool ExportToPdf(DataTable dt)
        {

            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo PDF";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "PDF File|.pdf";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Relatorio_Lancto" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
            //Define a extensão padrão como .txt
            saveFileDialog1.DefaultExt = ".pdf";
            //define o diretório padrão
            saveFileDialog1.InitialDirectory = @"c:\\";
            //restaura o diretorio atual antes de fechar a janela
            saveFileDialog1.RestoreDirectory = true;

            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = saveFileDialog1.ShowDialog();

            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                Document document = new Document();

                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                document.Open();
                iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 8);

                PdfPTable table = new PdfPTable(dt.Columns.Count);
                //PdfPRow row = null;
                float[] widths = new float[] { 2f, 2f, 2f, 3f, 3f, 2f, 4f, 3f, 2f, 3f };

                table.SetWidths(widths);

                table.WidthPercentage = 100;
                //int iCol = 0;
                //string colname = "";
                PdfPCell cell = new PdfPCell(new Phrase(""));

                cell.Colspan = dt.Columns.Count;

                dt.Columns[0].ColumnName = "ID";
                dt.Columns[1].ColumnName = "Conta";
                dt.Columns[2].ColumnName = "ID Segmento";
                dt.Columns[3].ColumnName = "Data";
                dt.Columns[4].ColumnName = "Valor";
                dt.Columns[5].ColumnName = "Tipo";
                dt.Columns[6].ColumnName = "Descrição";
                dt.Columns[7].ColumnName = "Observação";
                dt.Columns[8].ColumnName = "Cód. Usuário";
                dt.Columns[9].ColumnName = "Segmento";

                foreach (DataColumn c in dt.Columns)
                {

                    table.AddCell(new Phrase(c.ColumnName, font5));
                }

                foreach (DataRow r in dt.Rows)
                {
                    if (dt.Rows.Count > 0)
                    {
                        table.AddCell(new Phrase(r[0].ToString(), font5));
                        table.AddCell(new Phrase(r[1].ToString(), font5));
                        table.AddCell(new Phrase(r[2].ToString(), font5));
                        table.AddCell(new Phrase(r[3].ToString(), font5));
                        table.AddCell(new Phrase(r[4].ToString(), font5));
                        table.AddCell(new Phrase(r[5].ToString(), font5));
                        table.AddCell(new Phrase(r[6].ToString(), font5));
                        table.AddCell(new Phrase(r[7].ToString(), font5));
                        table.AddCell(new Phrase(r[8].ToString(), font5));
                        table.AddCell(new Phrase(r[9].ToString(), font5));
                    }
                }
                document.Add(table);
                document.Close();
                FuncoesBasicas.Mens("Arquivo gerado!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            ExportToPdf(AtualizaGrade(idUser));
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBaseFiltroId filtroIdConta = new frmBaseFiltroId("FIN");
            FuncoesBasicas.chamaForm(filtroIdConta, "modal");

            this.filtroId = filtroIdConta.filtroId;

            AtualizaGrade(idUser);
        }

        private void btnRemoverFiltro_Click(object sender, EventArgs e)
        {
            this.filtroId = "";

            AtualizaGrade(idUser);
        }
    }
}
