using SysFinance.BLL;
using SysFinance.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysFinance.UI.Formularios
{
    public partial class frmAjuda : SysFinance.UI.frmConsultar
    {
        UsuarioDTO usuario = new UsuarioDTO();
        UsuarioBLL obj = new UsuarioBLL();
        int idUser;
        bool naoIncomodar;

        public frmAjuda(int idUser, bool naoIncomodar = false)
        {
            this.idUser = idUser;
            this.naoIncomodar = naoIncomodar;

            InitializeComponent();

            lstRotinas.SetSelected(0, true);
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CallAjuda();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CallAjuda();
        }

        private void CallAjuda()
        {
            string ajudaSelecionada = this.lstRotinas.Text;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            string directory = FuncoesBasicas.GetDefaultPath("\\ImagensAjuda\\");

            if (ajudaSelecionada.Equals("1. Menu Principal"))
            {
                picBox.ImageLocation = @directory + "menu principal.JPG";
                lblTexto.Text = "Tela principal do sistema, navegando por essa tela você terá acesso através dos menus a todas as outras funcionalidades do SysFinance como Cadastros Básicos, Lançamentos e Relatórios e etc...";
            }
            else if (ajudaSelecionada.Equals("2. Arquivo"))
            {
                picBox.ImageLocation = @directory + "menu_arquivo.JPG";
                lblTexto.Text = "Acessando o menu Arquivo você tem a opção de efetuar logoff do sistema para logar com outro usuário ou sair do sistema. Existem teclas de atalho para sair e efetuar logof do sistema, são: CTRL + Q (Sair) e CTRL + L (logoff)";
            }
            else if (ajudaSelecionada.Equals("  2.1 Logoff"))
            {
                picBox.ImageLocation = @directory + "login.JPG";
                lblTexto.Text = "Caso queira efetuar o logoff do seu usuário, acesse o menu Arquivo e clique na opção Logoff, o sistema irá encerrar a sessão com o usuário atual e retornar a tela de Login, conforme imagem acima.";
            }
            else if (ajudaSelecionada.Equals("3. Cadastros Básicos"))
            {
                picBox.ImageLocation = @directory + "menu_cadastro.JPG";
                lblTexto.Text = "Para cadastrar dados no SysFinance, acesse o menu Cadastros e selecione entre Contas, Segmentos ou Usuários conforme imagem.";
            }
            else if (ajudaSelecionada.Equals("  3.1 Contas"))
            {
                picBox.ImageLocation = @directory + "contas consultar.JPG";
                lblTexto.Text = "Essa é a tela de gerenciamento de suas Contas, nela você poderá incluir, excluir, alterar e exportar relatórios em PDF ou Excel das suas contas." +
                    "\n\nPara Incluir\\Excluir\\Alterar basta você clicar com o botão direito em cima da grade ou acessando os botões na parte superior da tela. Detalhe: para excluir ou alterar é necessário que você selecione a linha do registro que deseja excluir ou alterar." +
                    "\n\nPara efetuar uma pesquisa de uma Conta, clique no botão de Pesquisa (lupa) e será aberto uma tela (exemplo no passo 6.2) onde você digitará a sua busca e selecionar a Conta desejada. Ou digite o código da sua conta e clique no botão Consultar.";
            }
            else if (ajudaSelecionada.Equals("    3.1.2 Inserindo\\Alterando"))
            {
                picBox.ImageLocation = @directory + "contas_digitar.JPG";
                lblTexto.Text = "\nPara inserir ou alterar uma conta, basta digitar os dados e clicar no botão Ok.";
            }
            else if (ajudaSelecionada.Equals("  3.2 Segmentos"))
            {
                picBox.ImageLocation = @directory + "segmentos_consultar.JPG";
                lblTexto.Text = lblTexto.Text = "Essa é a tela de gerenciamento de seus segmentos, nela você poderá incluir, excluir, alterar e exportar relatórios em PDF ou Excel de seus segmentos." +
                    "\n\nPara Incluir\\Excluir\\Alterar basta você clicar com o botão direito em cima da grade ou acessando os botões na parte superior da tela. Detalhe: para excluir ou alterar é necessário que você selecione a linha do registro que deseja excluir ou alterar." +
                    "\nPara excluir basta selecionar um segmento na grade e clicar no botão Excluir." +
                    "\n\nPara efetuar uma pesquisa de uma Conta, clique no botão de Pesquisa (lupa) e será aberto uma tela (exemplo no passo 6.2) onde você digitará a sua busca e selecionar o Segmento desejado. Ou digite o ID (código identificador) do Segmento e clique no botão Consultar.";
            }
            else if (ajudaSelecionada.Equals("    3.2.1 Inserindo\\Alterando"))
            {
                picBox.ImageLocation = @directory + "segmentos_digitar.JPG";
                lblTexto.Text = "\nPara inserir ou alterar um segmento, basta digitar a descrição e clicar no botão Ok.";
            }
            else if (ajudaSelecionada.Equals("  3.3 Usuários"))
            {
                picBox.ImageLocation = @directory + "usuarios_consultar.JPG";
                lblTexto.Text = "Essa é tela de administração de usuários, nela é possível incluir, alterar, trocar senha, configurar acesso e ativar/desativar usuários.\n" +
                    "\nPara Incluir\\Alterar\\Trocar Senha\\Configurar Acesso\\Ativar ou desativar usuários basta você clicar com o botão direito em cima da grade ou acessando os botões na parte superior da tela. Detalhe: É necessário selecionar o usuário antes, conforme imagem." +
                    "\nObs.:Ativar/Desativar: é uma opção para desativar totalmente o usuário do sistema, como se estivesse excluído, porém ele permanece salvo no sistema, basta selecionar o usuário e clicar no botão de Ativar/Desativar. Para reverter, basta ativá-lo. (Os usuários desativados serão exibidos com uma linha em cima das informações." +
                    "\nConfigurar acesso: opção para definir quais funcionalidades o usuário cadastrado terá acesso no SysFinance.";
            }
            else if (ajudaSelecionada.Equals("    3.3.1 Inserindo\\Alterando"))
            {
                picBox.ImageLocation = @directory + "usuarios_digitar.JPG";
                lblTexto.Text = "\nEssa é a tela para inserir ou alterar usuários, basta preencher os dados e clicar no botão Ok. Pronto seu usuário está salvo.";
            }
            else if (ajudaSelecionada.Equals("  3.4 Configurar Acesso"))
            {
                picBox.ImageLocation = @directory + "configurar_acesso.JPG";
                lblTexto.Text = "Essa é tela de configuração de acesso dos usuários. Para habilitar acesso basta selecionar as rotinas que o usuário possui direito.";
            }
            else if (ajudaSelecionada.Equals("  3.5 Trocar Senha"))
            {
                picBox.ImageLocation = @directory + "trocar_senha.JPG";
                lblTexto.Text = "Essa é a tela para trocar a senha do usuário, basta digitar a nova senha, confirmá-la e clicar no botão Ok.";
            }
            else if (ajudaSelecionada.Equals("4. Movimentos"))
            {
                picBox.ImageLocation = @directory + "menu_movimento.JPG";
                lblTexto.Text = "Acessando o menu de movimentos, você terá acesso a tela de Lançamentos.";
            }
            else if (ajudaSelecionada.Equals("  4.1 Lançamentos"))
            {
                picBox.ImageLocation = @directory + "lancamentos_consultar.JPG";
                lblTexto.Text = "Essa é a tela de lançamentos financeiros, nela você pode incluir, alterar, excluir e gerenciar seus lançamentos financeiros." +
                    "\nPara Incluir\\Alterar\\ basta você clicar com o botão direito em cima da grade ou acessando os botões de controle na parte superior da tela. Detalhe: É necessário selecionar algum lançamento antes, conforme imagem, exceto para incluir." +
                    "\nCaso queria excluir um lançamento, basta selecioná-lo e clicar no botão superior Excluir ou botão direto na grade e clicar na opção Excluir.";
            }
            else if (ajudaSelecionada.Equals("  4.1.2 Inserindo\\Alterando"))
            {
                picBox.ImageLocation = @directory + "lancamentos_digitar.JPG";
                lblTexto.Text = "\nPara incluir um lançamento basta digitar as informações nos campos, e ficar atento para marcar se é um lançamento de débito ou crédito.";
            }
            else if (ajudaSelecionada.Equals("5. Relatórios"))
            {
                picBox.ImageLocation = @directory + "menu_relatorio.JPG";
                lblTexto.Text = "Acessando o menu de Relatórios, você terá acesso aos relatórios de Extrato de Conta e Fluxo de Caixa";
            }
            else if (ajudaSelecionada.Equals("  5.1 Extrato de Contas"))
            {
                picBox.ImageLocation = @directory + "extrato.JPG";
                lblTexto.Text = "\nPara gerar um relatório de Fluxo de Caixa, preencha as opções do relatório conforme você deseja que ele seja gerado. Após esse passo clique no botão Prosseguir." +
                    "\nPronto! Na tela seguinte, será exibido o relatório gerado, podendo ser salvo em PDF ou Excel";
            }
            else if (ajudaSelecionada.Equals("  5.2 Fluxo de Caixa"))
            {
                picBox.ImageLocation = @directory + "fluxo_caixa.JPG";
                lblTexto.Text = "\nPara gerar um relatório de Extrato de Conta, preencha as opções do relatório conforme você deseja que ele seja gerado. Após esse passo clique no botão Prosseguir." +
                    "\nPronto! Na tela seguinte, será exibido o relatório gerado, podendo ser salvo em PDF ou Excel";
            }
            else if (ajudaSelecionada.Equals("6. Exportar dados"))
            {
                picBox.ImageLocation = @directory + "exportar_dados.JPG";
                lblTexto.Text = "\nEm todas as telas de cadastro e relatórios existe o botão de Salvar, que tem a funcionalidade de exportar os dados exibidos na grade para Excel ou PDF, conforme imagem.";
            }
            else if (ajudaSelecionada.Equals("6.1 Pesquisando dados"))
            {
                picBox.ImageLocation = @directory + "pesquisar_dados.JPG";
                lblTexto.Text = "Em cada tela de consulta que conter o botão de pesquisa com uma lupa, ao clicá-lo será exibido uma tela de pesquisa para que você possa pesquisar dados, conforme imagem." +
                    "\nAo encontrar o registro pesquisado, basta dar um duplo clique em cima dele, ou selecioná-lo e clicar no botão Ok.";
            }
            else
            {
                picBox.Image.Dispose();
                lblTexto.Text = "";
            }
        }

        private void frmAjuda_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!naoIncomodar) {
                if (chkAutoAjuda.Checked)
                {
                    if (!FuncoesBasicas.SimOuNao("Deseja realmente desabilitar o Auto ajuda do sistema ao iniciar?\n Obs.: Caso tenha dúvidas futuramente você poderá consultar o auto ajuda no menu de ajuda do sistema.", "SysFinance"))
                    {
                        return;
                    }

                    usuario.IdUsuario = this.idUser;
                    usuario.TgAutoAjuda = chkAutoAjuda.Checked ? 1 : 0;

                    obj.AtivarDesativarAutoAjuda(usuario);
                }
            }
        }
    }
}
