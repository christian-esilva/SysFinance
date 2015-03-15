using SysFinance.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFinance.BLL
{
    public class SelecaoDadosBLL
    {
        SelecaoDadosDAL obj = new SelecaoDadosDAL();

        #region selecionar dados
        public DataTable SelecionarDados(string tabela = "", string campobusca="", int idUser = 0, string filtro="")
        {
            return obj.SelecionarDados(tabela, campobusca, idUser,filtro);
        }
        #endregion

        #region validar dados selecionados
        public string Validar(object valor = null, string tabela = "", string campo = "", string campowhere = "PK_ID", int idUser = 0)
        {
            return obj.Validar(valor, tabela, campo, campowhere, idUser);
        }
        #endregion
    }
}
