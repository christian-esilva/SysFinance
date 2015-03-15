using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFinance.DAL
{
    public class SelecaoDadosDAL
    {
        AcessoDados sql = new AcessoDados();

        #region selecionar dados para selecao
        public DataTable SelecionarDados(string tabela="", string campobusca="", int idUser = 0, string filtro="")
        {
            string query;

            switch (tabela.ToUpper())
            {
                case "TB_SEGMENTOS": 
                    query = "SELECT PK_ID AS 'CÓDIGO', DS_SEGMENTO AS 'SEGMENTO' FROM TB_SEGMENTOS";
                    break;

                case "TB_CONTAS":
                    query = "SELECT DS_CODIGO AS 'CÓDIGO', DS_CONTA AS 'CONTA' FROM TB_CONTAS WHERE FK_USUARIO = " + idUser;
                    break;

                default:
                    query = "";
                    break;
            }

            if (!filtro.Equals(""))
            {
                query += query.Contains("WHERE") ? " AND " + campobusca + filtro : " WHERE " + campobusca + filtro;
            }

            DataTable table = sql.ExecutarConsulta(query);

            return table;
        }
        #endregion

        #region validar dados selecionados ou digitados
        public string Validar(object valor = null, string tabela = "", string campo = "", string campowhere= "PK_ID", int idUser = 0)
        {
            string query = "SELECT " + campo +
                           " FROM " + tabela +
                           " WHERE " + campowhere + " = @" + campowhere;

            sql.AddParametro(campowhere.Trim(), Convert.ToString(valor).Trim());

            if (idUser > 0) {
                query += " AND FK_USUARIO = " + idUser;
            }

            string valorRetorno = "";
            
            SqlDataReader reader = sql.retornaQuery(query);

            if (reader.Read())
            {
                valorRetorno = Convert.ToString(reader[0]).Trim();
            }
            else {
                valorRetorno = "";
            }
            
            return valorRetorno;
        }
        #endregion
    }
}
