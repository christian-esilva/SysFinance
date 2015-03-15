using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFinance.UI
{
    public static class FuncoesBasicas
    {
        public static string GetDefaultPath(String pasta)
        {
            String ret = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) +
                                pasta;

            // remove pasta de excução
            ret = ret.Replace("\\bin\\Debug", "");
            ret = ret.Replace("\\bin\\Release", "");

            return ret;

        }

        public static void Mens(String Mensagem, String Titulo = "Aviso")
        {
            MessageBox.Show(Mensagem, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        public static bool SimOuNao(String Mensagem, String Titulo = "Aviso")
        {
            return MessageBox.Show(Mensagem, Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        public static string PutFile(string Extensions, string Title = "Save file")
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = Extensions; // "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = Title; //"Save an Image File";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.ShowDialog();
            return saveFileDialog1.FileName;
        }

        public static bool StringVazia(String myString){
            Boolean retorno = true;
            
            retorno = !String.IsNullOrEmpty(myString);

            return retorno;
        }

        public static bool VerifObrigatorio(Form formulario,String camposObrig = "")
        {
            
            Boolean retorno = true;
            
            if (!FuncoesBasicas.StringVazia(camposObrig))
            {
                return true;
            }

            foreach (Control verifica in formulario.Controls)
            {
                if (verifica.GetType().Equals(typeof(TextBox)) ||
                    verifica.GetType().Equals(typeof(MaskedTextBox)) ||
                    verifica.GetType().Equals(typeof(ComboBox)))
                {
                    String nome = verifica.Name;
                    string[] campos = camposObrig.Split(',');

                    if (campos.Contains(nome))
                    {
                        if (verifica.Text == string.Empty)
                        {
                            verifica.BackColor = Color.Yellow;
                            retorno = false;
                        }   
                    }
                }
            }

            if (!retorno)
            {
                FuncoesBasicas.Mens("CAMPO DE PREENCHIMENTO OBRIGATÓRIO.");
            }

            return retorno;
        }

        public static bool verifRegistros(DataGridView grade) {
            Boolean retorno = true;

            if (grade.RowCount == 0)
            {
                retorno = false;
            }

            return (retorno);
        }

        public static void chamaForm(Form form, string modo="") {

            if (!FuncoesBasicas.StringVazia(modo))
            {
                form.Show();
            }
            else if (modo.ToUpper() == "MODAL")
            {
                form.ShowDialog();
            }
        }

        public static void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!txt.Text.Equals("")) {
                txt.Text = double.Parse(txt.Text).ToString("N");
            }
            
        }

        public static void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        public static void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        public static void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        public static void aplicarSoNro(object sender, KeyPressEventArgs e) {

            TextBox txt = (TextBox)sender;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        public static void soNumeros(TextBox txt) {
            txt.KeyPress += aplicarSoNro;
        }

        public static void abrirBusca(object sender, KeyEventArgs e, Button btn)
        {

            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.P:
                        btn.PerformClick();
                        break;
                }
            }

        }

        public static void autoFitGrade(DataGridView grade) {

            grade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in grade.Columns)
                col.Width = col.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, false);
        
        }

        public static decimal somarColGrade(DataGridView grade, string coluna ="") {

            decimal total = 0;
            int i = 0;
            for (i = 0; i < grade.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(grade.Rows[i].Cells[coluna].Value);
            }
           
            return total;

        }

        public static string trocaString(string strTroca="",string strTrocaEssa="",string strNovaPor="") {

            strTroca = strTroca.Replace(strTrocaEssa.ToUpper(), strNovaPor);

            return strTroca;
        
        }
    }
}
