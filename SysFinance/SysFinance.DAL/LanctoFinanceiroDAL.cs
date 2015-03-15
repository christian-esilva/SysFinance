using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SysFinance.DTO;

namespace SysFinance.DAL
{
    public class LanctoFinanceiroDAL
    {
        AcessoDados sql = new AcessoDados();

        #region incluir novo lancamento financeiro
        public void Incluir(LanctoFinanceiroDTO operacao)
        {
            try
            {
                string insert = @"INSERT INTO TB_OPERACOESFINANC (FK_CONTA, FK_SEGMENTO, FK_USUARIO, DS_LANCTO, DT_LANCTO, VL_LANCTO, TP_OPERACAO, DS_OBS)
                                  VALUES ( @FK_CONTA, @FK_SEGMENTO, @FK_USUARIO, @DS_LANCTO, @DT_LANCTO, @VL_LANCTO, @TP_OPERACAO, @DS_OBS)";

                sql.AddParametro("@FK_CONTA", operacao.FkConta);
                sql.AddParametro("@FK_SEGMENTO", operacao.FkSegmento);
                sql.AddParametro("@FK_USUARIO", operacao.FkUsuario);
                sql.AddParametro("@DS_LANCTO", operacao.DsLancto);
                sql.AddParametro("@DT_LANCTO", operacao.DtLancto);
                sql.AddParametro("@VL_LANCTO", operacao.VlLancto);
                sql.AddParametro("@TP_OPERACAO", operacao.TpOperacao);
                sql.AddParametro("@DS_OBS", operacao.DsObs);

                sql.ExecuteSql(insert);
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

        #region alterar lancamento financeiro
        public void Alterar(LanctoFinanceiroDTO operacao)
        {
            try
            {

                string update = "UPDATE TB_OPERACOESFINANC SET FK_CONTA = @FK_CONTA, FK_SEGMENTO = @FK_SEGMENTO, DS_LANCTO = @DS_LANCTO," +
                                " DT_LANCTO = @DT_LANCTO, VL_LANCTO = @VL_LANCTO, TP_OPERACAO = @TP_OPERACAO, DS_OBS = @DS_OBS" +
                                " WHERE PK_ID = @PK_ID";

                sql.AddParametro("@PK_ID", operacao.PkId);
                sql.AddParametro("@FK_CONTA", operacao.FkConta);
                sql.AddParametro("@FK_SEGMENTO", operacao.FkSegmento);
                sql.AddParametro("@FK_USUARIO", operacao.FkUsuario);
                sql.AddParametro("@DS_LANCTO", operacao.DsLancto);
                sql.AddParametro("@DT_LANCTO", operacao.DtLancto);
                sql.AddParametro("@VL_LANCTO", operacao.VlLancto);
                sql.AddParametro("@TP_OPERACAO", operacao.TpOperacao);
                sql.AddParametro("@DS_OBS", operacao.DsObs);

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

        #region excluir lancamento financeiro
        public void Excluir(int id)
        {
            try
            {
                sql.AddParametro("@PK_ID", id);
                string delete = "DELETE FROM TB_OPERACOESFINANC WHERE PK_ID = @PK_ID";
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

        #region carregar lancamentos financeiros
        public DataTable ListarLancamentos(int idUser, string param = "") {

            string query = @"SELECT FIN.PK_ID, COALESCE(FIN.FK_CONTA,'') AS FK_CONTA, COALESCE(FIN.FK_SEGMENTO,0) AS FK_SEGMENTO,
                             CONVERT(DATETIME,FIN.DT_LANCTO,103) AS DT_LANCTO, COALESCE(FIN.VL_LANCTO,0) AS VL_LANCTO,
                             COALESCE(FIN.TP_OPERACAO,'') AS TP_OPERACAO, COALESCE(FIN.DS_LANCTO,'') AS DS_LANCTO,
                             COALESCE(FIN.DS_OBS,'') AS DS_OBS, FIN.FK_USUARIO, COALESCE(SEG.DS_SEGMENTO,'') AS DS_SEGMENTO FROM TB_OPERACOESFINANC FIN
                             LEFT JOIN TB_SEGMENTOS SEG ON SEG.PK_ID = FIN.FK_SEGMENTO
                             WHERE FIN.FK_USUARIO = @FK_USUARIO ";

            sql.AddParametro("@FK_USUARIO",idUser);

            if (!param.Equals(""))
            {
                query += param;
            }

            DataTable table = sql.ExecutarConsulta(query);

            return table;
        }
        #endregion
    }
}
