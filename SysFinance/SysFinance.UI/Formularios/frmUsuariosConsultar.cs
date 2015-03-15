using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysFinance.BLL;
using SysFinance.DTO;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SysFinance.UI.Base;

namespace SysFinance.UI.Formularios
{
    public partial class frmUsuariosConsultar : SysFinance.UI.frmConsultar
    {

        UsuarioBLL obj = new UsuarioBLL();
        UsuarioDTO usuario = new UsuarioDTO();

        public frmUsuariosConsultar()
        {
            InitializeComponent();
            cboTgUsuario.SelectedIndex = 0;
            AtualizaGrade();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            if (!FuncoesBasicas.verifRegistros(dgvUsuarios))
            {
                FuncoesBasicas.Mens("Selecione algum usuário para aplicar os devidos direitos", "SysFinance");
                return;
            }

            usuario.IdUsuario = (Int32)dgvUsuarios.CurrentRow.Cells[0].Value;
            usuario.DsNome = (string)dgvUsuarios.CurrentRow.Cells[1].Value;
            usuario.TgInativo = (int)dgvUsuarios.CurrentRow.Cells[6].Value;

            if (usuario.TgInativo == 1) {
                FuncoesBasicas.Mens("Não é possível configurar direitos de acesso para usuários inativos", "SysFinance");
                return;
            }

            frmConfigurarAcesso configAcesso = new frmConfigurarAcesso(usuario);
            FuncoesBasicas.chamaForm(configAcesso, "modal");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmUsuariosDigitar usuariosDigitar = new frmUsuariosDigitar(AcaoSql.Incluir, null);
            FuncoesBasicas.chamaForm(usuariosDigitar, "modal");
            AtualizaGrade();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!FuncoesBasicas.verifRegistros(dgvUsuarios))
                {
                    FuncoesBasicas.Mens("Não existem dados a serem alterados", "SysFinance");
                    return;
                }

                usuario.IdUsuario   = (Int32)dgvUsuarios.CurrentRow.Cells[0].Value;
                usuario.DsNome      = (string)dgvUsuarios.CurrentRow.Cells[1].Value;
                usuario.DsLogin     =  (string)dgvUsuarios.CurrentRow.Cells[2].Value;
                usuario.DsEmail     = (string)dgvUsuarios.CurrentRow.Cells[3].Value;
                usuario.DsSenha     = (string)dgvUsuarios.CurrentRow.Cells[5].Value;
                usuario.TgInativo   = (int)dgvUsuarios.CurrentRow.Cells[6].Value;

                if (Convert.ToInt32(usuario.TgInativo).Equals(1))
                {
                    FuncoesBasicas.Mens("Não é possível alterar usuários inativos.", "SysFinance");
                    return;
                }

                frmUsuariosDigitar usuariosDigitar = new frmUsuariosDigitar(AcaoSql.Alterar, usuario);
                FuncoesBasicas.chamaForm(usuariosDigitar, "modal");

                AtualizaGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar." + ex, "SysFinance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizaGrade()
        {
            Object selectedItem = cboTgUsuario.SelectedItem;
            string condicao = selectedItem.ToString().Trim().Substring(0, 1);

            if(!this.filtroId.Equals("")){
                condicao = this.filtroId;

                condicao = condicao.Replace("AND","WHERE");

            }else{
                if (!condicao.Equals("T"))
                {
                    condicao = "WHERE TG_INATIVO = " + condicao + "";
                }
                else
                {
                    condicao = "";
                }
            }


            dgvUsuarios.DataSource = obj.CarregaGrade(condicao);

            foreach (DataGridViewRow row in dgvUsuarios.Rows)
                if (row.Cells[6].Value.Equals(1))
                    row.DefaultCellStyle.Font = new System.Drawing.Font(this.Font, FontStyle.Strikeout);

            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "SysFinance",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrade();
        }

        public void ExportToExcel(DataTable dt)
        {
            //implementar

            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo XLS";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "XLS File|.xls";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Rel_Usuarios" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
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
                sh.Cells[3, "B"].Value2 = "Nome do Usuário";
                sh.Cells[3, "C"].Value2 = "Login";
                sh.Cells[3, "D"].Value2 = "E-mail";
                sh.Cells[3, "E"].Value2 = "Máquina";
                sh.Cells[3, "F"].Value2 = "Ativo/Inativo";

                /* Insert Rows */
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sh.Cells[i + 4, "A"].Value2 = dt.Rows[i][0]; // ID
                    sh.Cells[i + 4, "B"].Value2 += dt.Rows[i][1]; // nome
                    sh.Cells[i + 4, "C"].Value2 += dt.Rows[i][2]; // login
                    sh.Cells[i + 4, "D"].Value2 += dt.Rows[i][3]; // e-mail
                    sh.Cells[i + 4, "E"].Value2 += dt.Rows[i][4]; // maquina
                    sh.Cells[i + 4, "F"].Value2 += dt.Rows[i][6]; // ativo
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

        public bool ExportToPdf(DataTable dt)
        {
            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo PDF";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "PDF File|.pdf";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Rel_Usuario" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
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
                float[] widths = new float[] { 4f, 4f, 4f, 4f, 4f, 4f};

                table.SetWidths(widths);

                table.WidthPercentage = 100;
                //int iCol = 0;
                //string colname = "";
                PdfPCell cell = new PdfPCell(new Phrase(""));

                cell.Colspan = dt.Columns.Count;

                dt.Columns[0].ColumnName = "ID";
                dt.Columns[1].ColumnName = "Nome do Usuário";
                dt.Columns[2].ColumnName = "Login";
                dt.Columns[3].ColumnName = "E-mail";
                dt.Columns[4].ColumnName = "Máquina";
                dt.Columns[5].ColumnName = "Ativo/Inativo";

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

        private void btnExportarXls_Click(object sender, EventArgs e)
        {
            ExportToExcel(obj.CarregaGrade());
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            ExportToPdf(obj.CarregaGrade());
        }

        private void dgvUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dgvUsuarios.HitTest(e.X, e.Y).RowIndex;

                m.MenuItems.Add(new MenuItem("Incluir", btnInserir_Click));
                m.MenuItems.Add(new MenuItem("Alterar", btnAlterar_Click));
                m.MenuItems.Add(new MenuItem("Configurar acesso", btnConfigurar_Click));
                m.MenuItems.Add(new MenuItem("-"));
                m.MenuItems.Add(new MenuItem("Ativar/Desativar", btnDesabilitarAtivar_Click));
                m.MenuItems.Add(new MenuItem("-"));
                m.MenuItems.Add(new MenuItem("Trocar Senha", btnTrocarSenha_Click));

                m.Show(dgvUsuarios, new Point(e.X, e.Y));
            }
        }

        private void btnDesabilitarAtivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FuncoesBasicas.verifRegistros(dgvUsuarios))
                {
                    FuncoesBasicas.Mens("Não existem usuários a serem ativados/inativados", "SysFinance");
                    return;
                }

                usuario.IdUsuario = (int)dgvUsuarios.CurrentRow.Cells[0].Value;
                usuario.TgInativo = (int)dgvUsuarios.CurrentRow.Cells[6].Value;

                if (FuncoesBasicas.SimOuNao("Deseja inativar/ativar o usuário selecionado " + usuario.IdUsuario + "?", "SysFinance"))
                {
                    obj.AtivarDesativar(usuario);
                    AtualizaGrade();
                }
            }
            catch (Exception ex)
            {
                FuncoesBasicas.Mens("Não foi possível excluir." + ex, "SysFinance");
            }
        }

        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            if (!FuncoesBasicas.verifRegistros(dgvUsuarios))
            {
                FuncoesBasicas.Mens("Favor selecionar o usuário para troca de senha", "SysFinance");
                return;
            }

            usuario.IdUsuario = (int)dgvUsuarios.CurrentRow.Cells[0].Value;
            usuario.DsNome = (string)dgvUsuarios.CurrentRow.Cells[1].Value;

            frmTrocarSenha TrocaSenha = new frmTrocarSenha(usuario);
            FuncoesBasicas.chamaForm(TrocaSenha, "modal");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBaseFiltroId filtroIdConta = new frmBaseFiltroId();
            FuncoesBasicas.chamaForm(filtroIdConta, "modal");

            this.filtroId = filtroIdConta.filtroId;

            AtualizaGrade();
        }

        private void btnRemoverFiltro_Click(object sender, EventArgs e)
        {
            this.filtroId = "";
            AtualizaGrade();
        }
    }
}
