using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SysFinance.DTO;
using SysFinance.BLL;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SysFinance.UI.Base;

namespace SysFinance.UI.Formularios
{
    public partial class frmContasConsultar : SysFinance.UI.frmConsultar
    {
        ContaBLL obj = new ContaBLL();
        ContaDTO conta = new ContaDTO();
        SelecaoDadosBLL selDados = new SelecaoDadosBLL();
        int idUser;

        public frmContasConsultar(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            AtualizaGrade(idUser);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmContasDigitar contasDigitar = new frmContasDigitar(AcaoSql.Incluir, null, idUser);
            FuncoesBasicas.chamaForm(contasDigitar, "modal");
            AtualizaGrade(idUser);
        }

        public void AtualizaGrade(int idUser)
        {
            string query = "";

            if (!this.filtroId.Equals(""))
            {
                query += this.filtroId;
            }
            else
            {
                if (FuncoesBasicas.StringVazia(this.txtFkConta.Text))
                {
                    query = "AND DS_CODIGO = '" + this.txtFkConta.Text + "'";
                }
            }

            dgvContas.DataSource = obj.CarregaGrade(idUser, query);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrade(idUser);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FuncoesBasicas.verifRegistros(dgvContas))
                {
                    FuncoesBasicas.Mens("Não existem dados a serem alterados", "SysFinance");
                    return;
                }

                Int32 id = (Int32)dgvContas.CurrentRow.Cells[0].Value;
                string codigo = (string)dgvContas.CurrentRow.Cells[1].Value;
                string desc = (string)dgvContas.CurrentRow.Cells[2].Value;

                conta.IdConta = id;
                conta.DsCodigo = codigo;
                conta.DsConta = desc;

                frmContasDigitar usuariosDigitar = new frmContasDigitar(AcaoSql.Alterar, conta, idUser);
                FuncoesBasicas.chamaForm(usuariosDigitar, "modal");
                AtualizaGrade(idUser);
            }
            catch (Exception ex)
            {
                FuncoesBasicas.Mens("Não foi possível alterar. " + ex, "SysFinance");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FuncoesBasicas.verifRegistros(dgvContas))
                {
                    FuncoesBasicas.Mens("Não existem dados a serem deletados", "SysFinance");
                    return;
                }

                string codigo = (string)dgvContas.CurrentRow.Cells[1].Value;

                if (FuncoesBasicas.SimOuNao("Deseja excluir o registro selecionado " + codigo.Trim() + "?", "SysFinance"))
                {

                    Int32 id = (Int32)dgvContas.CurrentRow.Cells[0].Value;

                    bool retorno = obj.VerificarExclusao(id);

                    if (!retorno)
                    {
                        FuncoesBasicas.Mens("Não é possível excluir a conta selecionada, existem lançamentos vinculados a está conta.", "SysFinance");
                        return;
                    }

                    FuncoesBasicas.Mens("Registro excluído com sucesso.", "SysFinance");
                    AtualizaGrade(idUser);
                }
            }
            catch (Exception ex)
            {
                FuncoesBasicas.Mens("Não foi possível excluir." + ex, "SysFinance");
            }
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
            saveFileDialog1.FileName = "Rel_Contas" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
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
                float[] widths = new float[] { 1f, 2f, 4f };

                table.SetWidths(widths);

                table.WidthPercentage = 100;
                //int iCol = 0;
                //string colname = "";
                PdfPCell cell = new PdfPCell(new Phrase(""));

                cell.Colspan = dt.Columns.Count;

                dt.Columns[0].ColumnName = "ID";
                dt.Columns[1].ColumnName = "Código";
                dt.Columns[2].ColumnName = "Descrição";

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

        public void ExportToXls(DataTable dt)
        {
            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo XLS";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "XLS File|.xls";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Rel_Contas" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
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
                sh.Name = "Rel_Usuarios";
                sh.Cells[1, "A"].Value2 = "Relatório de Usuários - SysFinance";
                sh.Cells[2, "A"].Value2 = "Gerado em: " + System.DateTime.Now;
                sh.Cells[3, "A"].Value2 = "ID";
                sh.Cells[3, "B"].Value2 = "Código";
                sh.Cells[3, "C"].Value2 = "Descrição";

                /* Insert Rows */
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sh.Cells[i + 4, "A"].Value2 = dt.Rows[i][0]; // ID
                    sh.Cells[i + 4, "B"].Value2 += dt.Rows[i][1]; // codigo
                    sh.Cells[i + 4, "C"].Value2 += dt.Rows[i][2]; // conta
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
            ExportToPdf(obj.CarregaGrade(idUser));
        }

        private void btnExportarXls_Click(object sender, EventArgs e)
        {
            ExportToXls(obj.CarregaGrade(idUser));
        }

        private void dgvContas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dgvContas.HitTest(e.X, e.Y).RowIndex;

                m.MenuItems.Add(new MenuItem("Incluir", btnInserir_Click));
                m.MenuItems.Add(new MenuItem("Alterar", btnAlterar_Click));
                m.MenuItems.Add(new MenuItem("Excluir", btnExcluir_Click));
                m.Show(dgvContas, new Point(e.X, e.Y));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AtualizaGrade(idUser);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
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
            FuncoesBasicas.abrirBusca(sender, e, this.btnPesquisar);
        }

        private void txtFkConta_Leave(object sender, EventArgs e)
        {
            validarConta(txtFkConta.Text.Trim());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBaseFiltroId filtroIdConta = new frmBaseFiltroId();
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
