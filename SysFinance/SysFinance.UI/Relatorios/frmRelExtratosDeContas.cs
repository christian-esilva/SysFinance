using SysFinance.BLL;
using SysFinance.UI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SysFinance.UI.Formularios
{
    public partial class frmRelExtratosDeContas : SysFinance.UI.Base.frmBaseRelatorio
    {

        SelecaoDadosBLL selDados = new SelecaoDadosBLL();
        RelatoriosBLL obj = new RelatoriosBLL();

        int idUser;

        public frmRelExtratosDeContas(int idUser=0)
        {
            this.idUser = idUser;
           
            InitializeComponent();

            FuncoesBasicas.soNumeros(txtFkSegmento);
            cmbTpOperacao.SelectedIndex = 0;
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

        private void txtFkConta_KeyDown(object sender, KeyEventArgs e)
        {
            FuncoesBasicas.abrirBusca(sender, e, this.btnPesquisarConta);
        }

        private void txtFkConta_Leave(object sender, EventArgs e)
        {
            validarConta(txtFkConta.Text.Trim());
        }

        private void btnPesquisarSegmento_Click(object sender, EventArgs e)
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

        private void txtFkSegmento_KeyDown(object sender, KeyEventArgs e)
        {
            FuncoesBasicas.abrirBusca(sender, e, this.btnPesquisarSegmento);
        }

        private void txtFkSegmento_Leave(object sender, EventArgs e)
        {
            validarSegmento(txtFkSegmento.Text.Trim());
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {

            if (txtFkConta.Text.Equals("")) {
                txtFkConta.BackColor = Color.Yellow;
                FuncoesBasicas.Mens("CAMPO DE PREENCHIMENTO OBRIGATÓRIO.");
                return;
            }

            CarregarRelatorio(idUser);
        }

        public string CarregarRelatorio(int idUser) {

            string query = "";

            query = " WHERE DT_LANCTO >= CONVERT(DATETIME,'" + dtpDtMovtoDe.Value + "',103)";
            query += " AND DT_LANCTO <=  CONVERT(DATETIME,'" + dtpDtMovtoAte.Value + "',103)";

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

            dgvExtratoConta.DataSource = obj.CarregarExtrato(idUser, query);

            tbcRelatorio.SelectedTab = tbpDados;

            FuncoesBasicas.autoFitGrade(dgvExtratoConta);
            txtVlSaldoFinal.Text = Convert.ToString(FuncoesBasicas.somarColGrade(dgvExtratoConta,"valor"));

            corStatusSaldoTxt(txtVlSaldoFinal);

            DateTime dtAgora = DateTime.Now;
            lblExibido.Text = FuncoesBasicas.trocaString(lblExibido.Text, "data", Convert.ToString(dtAgora));

            return query;
        }

        public void corStatusSaldoTxt(TextBox txt) {

            decimal valor;

            valor = Convert.ToDecimal(txt.Text);
            txt.ForeColor = valor < 0 ? Color.Red : Color.Black;
        }

        private void btnExportarXls_Click(object sender, EventArgs e)
        {
            ExportToXls(obj.CarregarExtrato(idUser, CarregarRelatorio(idUser)));
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
            saveFileDialog1.FileName = "Extrato_Conta" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
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
                sh.Name = "Extrato de Conta";
                sh.Cells[1, "A"].Value2 = "Extrato de conta - SysFinance";
                sh.Cells[2, "A"].Value2 = "Gerado em: " + System.DateTime.Now;
                sh.Cells[3, "A"].Value2 = "Data";
                sh.Cells[3, "B"].Value2 = "Descrição";
                sh.Cells[3, "C"].Value2 = "Vl. Lançamento R$";
                sh.Cells[3, "D"].Value2 = "Tipo";

                /* Insert Rows */
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sh.Cells[i + 4, "A"].Value2 = dt.Rows[i][0]; 
                    sh.Cells[i + 4, "B"].Value2 += dt.Rows[i][1]; 
                    sh.Cells[i + 4, "C"].Value2 += dt.Rows[i][2]; 
                    sh.Cells[i + 4, "D"].Value2 += dt.Rows[i][3]; 
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

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            ExportToPdf(obj.CarregarExtrato(idUser, CarregarRelatorio(idUser)));
        }

        public bool ExportToPdf(DataTable dt)
        {

            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo PDF";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "PDF File|.pdf";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Extrato_conta" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
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
                float[] widths = new float[] { 3f, 4f, 3f, 2f };

                table.SetWidths(widths);

                table.WidthPercentage = 100;
                //int iCol = 0;
                //string colname = "";
                PdfPCell cell = new PdfPCell(new Phrase(""));

                cell.Colspan = dt.Columns.Count;

                dt.Columns[0].ColumnName = "Data";
                dt.Columns[1].ColumnName = "Descrição";
                dt.Columns[2].ColumnName = "Valor R$";
                dt.Columns[3].ColumnName = "Tipo";

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

    }
}
