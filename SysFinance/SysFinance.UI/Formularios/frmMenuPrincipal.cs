using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysFinance.UI.Formularios;
using SysFinance.DTO;
using SysFinance.BLL;
using System.Data.SqlClient;

namespace SysFinance.UI
{
    public partial class frmMenuPrincipal : Form
    {

        int idUser;
        public object autoAjuda { get; set; }
        DireitoAcessoDTO acesso = new DireitoAcessoDTO();
        DireitoAcessoBLL obj = new DireitoAcessoBLL();

        public frmMenuPrincipal(UsuarioDTO usuario)
        {
            InitializeComponent();
            this.lblUsuario.Text = "Nome Usuário: " + usuario.DsNome.ToString();
            idUser = usuario.IdUsuario;
            autoAjuda = usuario.TgAutoAjuda;
            
            CarregarDireitos(usuario.IdUsuario);
        }

        public void CarregarDireitos(int codUsuario)
        {
            SqlDataReader direitos = obj.CarregarDireitos(codUsuario);

            if (direitos.Read())
            {
                this.mnuUsuarios.Enabled = Convert.ToInt32(direitos[2]) > 0 ? true : false;
                this.mnuSegmentos.Enabled = Convert.ToInt32(direitos[3]) > 0 ? true : false;
                this.mnuContas.Enabled = Convert.ToInt32(direitos[4]) > 0 ? true : false;
                this.mnuLancamentos.Enabled = Convert.ToInt32(direitos[5]) > 0 ? true : false;
                this.mnuFluxoDeCaixa.Enabled = Convert.ToInt32(direitos[6]) > 0 ? true : false;
                this.mnuExtratos.Enabled = Convert.ToInt32(direitos[7]) > 0 ? true : false;
            }
        }

        private void Pressionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Q:
                        encerrarSistema();
                        break;

                    case Keys.L:
                        this.mnuLogoff_Click(sender, e);
                        break;
                }
            }
        }

        private void mnuLogoff_Click(object sender, EventArgs e)
        {
            if (FuncoesBasicas.SimOuNao("Deseja efetuar o logoff?", "SysFinance"))
            {
                frmLogin login = new frmLogin();
                FuncoesBasicas.chamaForm(login);
                this.Close();
            }
        }

        private void mnuExtratos_Click(object sender, EventArgs e)
        {
            frmRelExtratosDeContas extrato = new frmRelExtratosDeContas(idUser);
            FuncoesBasicas.chamaForm(extrato,"modal");
        }

        private void mnuContas_Click(object sender, EventArgs e)
        {
            frmContasConsultar contasConsul = new frmContasConsultar(idUser);
            FuncoesBasicas.chamaForm(contasConsul,"modal");
        }

        private void mnuSegmentos_Click(object sender, EventArgs e)
        {
            frmSegmentosConsultar segConsul = new frmSegmentosConsultar();
            FuncoesBasicas.chamaForm(segConsul, "modal");
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuariosConsultar usuarioConsultar = new frmUsuariosConsultar();
            FuncoesBasicas.chamaForm(usuarioConsultar, "modal");
        }

        private void mnuLancamentos_Click(object sender, EventArgs e)
        {
            frmLancamentosConsultar lancConsul = new frmLancamentosConsultar(idUser);
            FuncoesBasicas.chamaForm(lancConsul, "modal");
        }

        private void mnuFluxoDeCaixa_Click(object sender, EventArgs e)
        {
            frmRelFluxoDeCaixa fluxoCaixa = new frmRelFluxoDeCaixa(idUser);
            FuncoesBasicas.chamaForm(fluxoCaixa, "modal");
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            FuncoesBasicas.Mens("Integrantes: \nAugusto Cordier Serafim\nChristian Eufrasio da Silva\nErnando Rocha Silva\nLeonardo Augusto Monteiro\n\nVersão: 3.0", "SysFinance");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string hora = DateTime.Now.ToLongTimeString();
            lblData.Text = "Data: " + dia + "/" + mes + "/" + ano;
            lblHora.Text = "Hora: " + hora;
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            encerrarSistema();
        }

        private void mnuVerAjuda_Click(object sender, EventArgs e)
        {
            frmAjuda ajuda = new frmAjuda(idUser,true);
            FuncoesBasicas.chamaForm(ajuda, "modal");
        }

        private void encerrarSistema(){
            if (FuncoesBasicas.SimOuNao("Deseja sair do sistema?","SysFinance"))
            {
                Application.Exit();
            }
        }
    }
}
