using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SysFinance.DAL.Properties;
using SysFinance.DTO;

namespace SysFinance.DAL
{
    public class SegmentoDAL
    {
        AcessoDados sql = new AcessoDados();

        #region incluir novo segmento
        public void Incluir(SegmentoDTO segmento)
        {
            try
            {

                sql.AddParametro("@DS_SEGMENTO", segmento.DsSegmento);

                string insert = "INSERT INTO TB_SEGMENTOS (DS_SEGMENTO) VALUES (@DS_SEGMENTO)";

                segmento.IdSegmento = Convert.ToInt32(sql.ExecuteSql(insert));
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no servidor SQL Server:" + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro durante a operação: " + e.Message);
            }
        }
        #endregion

        #region alterar segmentos
        public void Alterar(SegmentoDTO segmento)
        {
            try
            {
                sql.AddParametro("@PK_ID", segmento.IdSegmento);
                sql.AddParametro("@DS_SEGMENTO", segmento.DsSegmento);

                string update = "UPDATE TB_SEGMENTOS SET DS_SEGMENTO = @DS_SEGMENTO WHERE PK_ID = @PK_ID";
                sql.executaQueryIdentity(update);
            }
            catch (SqlException e)
            {
                throw new Exception("Erro no servidor SQL Server:" + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro durante a operação: " + e.Message);
            }
        }
        #endregion

        #region exlcuir segmentos
        public void Excluir(int id)
        {

            try
            {
                sql.AddParametro("@PK_ID", id);
                string delete = "DELETE FROM TB_SEGMENTOS WHERE PK_ID = @PK_ID";
                sql.executaQuery(delete);
            }

            catch (SqlException e)
            {
                throw new Exception("Erro no servidor SQL Server:" + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro durante a operação: " + e.Message);
            }
        }
        #endregion

        #region carregar segmentos
        public DataTable ListarSegmentos(string param)
        {
            try
            {
                string query = "SELECT * FROM TB_SEGMENTOS";

                if (!param.Equals(""))
                {
                    query += param;
                }

                DataTable table = sql.ExecutarConsulta(query);

                return table;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion

        #region verificar segmento
        public bool verifCampo(string valor)
        {
            string query = "SELECT PK_ID FROM TB_SEGMENTOS WHERE DS_SEGMENTO = @DS_SEGMENTO";

            sql.AddParametro("@DS_SEGMENTO", valor);

            int qtREG = Convert.ToInt32(sql.ExecuteSql(query));

            if (qtREG == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
