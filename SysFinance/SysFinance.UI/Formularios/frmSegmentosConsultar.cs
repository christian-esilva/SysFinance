using iTextSharp.text;
using iTextSharp.text.pdf;
using SysFinance.BLL;
using SysFinance.DTO;
using SysFinance.UI.Base;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SysFinance.UI.Formularios
{
    public partial class frmSegmentosConsultar : SysFinance.UI.frmConsultar
    {
        SegmentoBLL obj = new SegmentoBLL();
        SegmentoDTO segmento = new SegmentoDTO();
        SelecaoDadosBLL selDados = new SelecaoDadosBLL();
        
        public frmSegmentosConsultar()
        {
            InitializeComponent();
            //dgvSegmentos.AutoGenerateColumns = false;
            FuncoesBasicas.soNumeros(txtFkSegmento);
            AtualizaGrade();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmSegmentosDigitar segmentosDigitar = new frmSegmentosDigitar(AcaoSql.Incluir, null);
            FuncoesBasicas.chamaForm(segmentosDigitar, "modal");    
            AtualizaGrade();
        }

        public void AtualizaGrade()
        {
            string query = "";

            if(!this.filtroId.Equals("")){
                query += this.filtroId;

                query = query.Replace("AND", "WHERE");
            }else{
                if (FuncoesBasicas.StringVazia(this.txtFkSegmento.Text))
                {
                    query = " WHERE PK_ID = " + this.txtFkSegmento.Text;
                }
            }

            dgvSegmentos.DataSource = obj.CarregaGrade(query);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (!FuncoesBasicas.verifRegistros(dgvSegmentos))
            {
                FuncoesBasicas.Mens("Não existem dados a serem excluidos", "SysFinance");
                return;
            }

            Int32 id = (Int32)dgvSegmentos.CurrentRow.Cells[0].Value;

            if (!FuncoesBasicas.SimOuNao("Deseja excluir o registro selecionado " + id + "?", "SysFinance"))
            {
                return;
            }

            try
            {
                obj.Excluir(id);
                FuncoesBasicas.Mens("Registro excluído com sucesso.", "SysFinance");
                AtualizaGrade();
            }
            catch (Exception)
            {
                FuncoesBasicas.Mens("Não é possível excluir o registro. Existem lançamentos vinculados a este segmento.", "SysFinance");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrade();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!FuncoesBasicas.verifRegistros(dgvSegmentos))
            {
                FuncoesBasicas.Mens("Não existem dados a serem alterados", "SysFinance");
                return;
            }

            Int32 id = (Int32)dgvSegmentos.CurrentRow.Cells[0].Value;
            string desc = (string)dgvSegmentos.CurrentRow.Cells[1].Value;

            segmento.IdSegmento = id;
            segmento.DsSegmento = desc;

            frmSegmentosDigitar segmentosDigitar = new frmSegmentosDigitar(AcaoSql.Alterar, segmento);
            FuncoesBasicas.chamaForm(segmentosDigitar, "modal");

            AtualizaGrade();
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            ExportToPdf(obj.CarregaGrade());
        }

        public bool ExportToPdf(DataTable dt)
        {
            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo PDF";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "PDF File|.pdf";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0 ;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Rel_Seg" +  DateTime.Now.ToString("ddMMyyyy_HHmmss");
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
                float[] widths = new float[] { 4f, 4f };

                table.SetWidths(widths);

                table.WidthPercentage = 100;
                //int iCol = 0;
                //string colname = "";
                PdfPCell cell = new PdfPCell(new Phrase(""));

                cell.Colspan = dt.Columns.Count;

                dt.Columns[0].ColumnName = "ID";
                dt.Columns[1].ColumnName = "Descrição";

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

        public void ExportToExcel(DataTable dt)
        {
            //implementar
             
            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo XLS";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "XLS File|.xls";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0 ;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Rel_Seg" +  DateTime.Now.ToString("ddMMyyyy_HHmmss");
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
                //var wb = excel.Workbooks.Open(PathFileName);
                Excel.Worksheet sh = wb.Sheets.Add();
                sh.Name = "Rel_Segmentos";
                sh.Cells[1, "A"].Value2 = "Relatório de Segmentos - SysFinance";
                sh.Cells[2, "A"].Value2 = "Gerado em: " + System.DateTime.Now;
                sh.Cells[3, "A"].Value2 = "ID";
                sh.Cells[3, "B"].Value2 = "Descrição";

                /* Insert Rows */
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sh.Cells[i + 4, "A"].Value2 = dt.Rows[i][0]; // ID
                    sh.Cells[i + 4, "B"].Value2 += dt.Rows[i][1]; // Desc
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

        public void ExportToTxt(DataTable dt)
        {
            //implementar
        }

        private void btnExportarXls_Click(object sender, EventArgs e)
        {
            ExportToExcel(obj.CarregaGrade());
        }

        private void dgvSegmentos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dgvSegmentos.HitTest(e.X, e.Y).RowIndex;

                m.MenuItems.Add(new MenuItem("Incluir", btnInserir_Click));
                m.MenuItems.Add(new MenuItem("Alterar", btnAlterar_Click));
                m.MenuItems.Add(new MenuItem("Excluir", btnExcluir_Click));
                m.Show(dgvSegmentos, new Point(e.X, e.Y));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AtualizaGrade();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBaseSelecionar selContas = new frmBaseSelecionar("SEGMENTOS", "TB_SEGMENTOS", "Segmento", "DS_SEGMENTO");
            FuncoesBasicas.chamaForm(selContas, "modal");

            txtFkSegmento.Text = selContas.ValorRetorno.ToString();

            validarSegmento(txtFkSegmento.Text.Trim());
        }

        private void txtFkSegmento_Leave(object sender, EventArgs e)
        {
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
            else {
                txtDsSegmento.Text = "";
            }
        }

        private void txtFkSegmento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.P:
                        btnPesquisar.PerformClick();
                        break;
                }
            }
        }

        private void btnRemoverFiltro_Click(object sender, EventArgs e)
        {
            this.filtroId = "";
            AtualizaGrade();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBaseFiltroId filtroIdConta = new frmBaseFiltroId();
            FuncoesBasicas.chamaForm(filtroIdConta, "modal");

            this.filtroId = filtroIdConta.filtroId;

            AtualizaGrade();
        }
    }
}
