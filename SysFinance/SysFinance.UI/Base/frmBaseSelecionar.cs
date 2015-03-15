using SysFinance.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFinance.UI.Base
{
    public partial class frmBaseSelecionar : Form
    {
        public object ValorRetorno { get; set; }
        int idUser;
        string nomeTab, nomeCampo;
        SelecaoDadosBLL selDados = new SelecaoDadosBLL();

        public frmBaseSelecionar(string aliasTab = "", string nomeTab = "", string aliasCampo = "", string nomeCampo = "", int idUser = 0)
        {
            InitializeComponent();

            this.Text += ": " + aliasTab;
            lblBusca.Text = lblBusca.Text.Replace("CAMPO", aliasCampo.ToUpper());

            this.idUser = idUser;
            this.nomeTab = nomeTab;
            this.nomeCampo = nomeCampo;

            CarregarDados();

            dgvDados.AutoResizeColumns();
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void CarregarDados(string filtro = "")
        {
            this.dgvDados.DataSource = selDados.SelecionarDados(nomeTab, nomeCampo, idUser, filtro);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ValorRetorno = "";
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!FuncoesBasicas.verifRegistros(dgvDados))
            {
                FuncoesBasicas.Mens("Não existem dados a serem retornados", "SysFinance");
                return;
            }

            ValorRetorno = dgvDados.CurrentRow.Cells[0].Value;

            if (ValorRetorno.Equals(null))
            {
                ValorRetorno = "";
            }

            this.Close();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk.PerformClick();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            string filtro;

            filtro = !chkBuscarNoMeio.Checked ? " = '" + txtBuscar.Text.Trim() + "'" : " LIKE '%" + txtBuscar.Text.Trim() + "%'";

            CarregarDados(filtro);
        }

        private void frmBaseSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                btnCancelar.PerformClick();
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
