using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFinance.DAL
{
    public class RelatoriosDAL
    {

        AcessoDados sql = new AcessoDados();

        #region Relatório de extrato
        public DataTable CarregarExtrato(int idUser, string param = "")
        {

            try
            {
                string query = @"SELECT
                               DT_LANCTO,
                               COALESCE(DS_LANCTO,'') AS DS_LANCTO,
                               COALESCE(CASE
                                    WHEN TP_OPERACAO = 'C' THEN VL_LANCTO
                                    WHEN TP_OPERACAO = 'D' THEN (VL_LANCTO) * (-1) END,0) AS VL_LANCTO,
                                TP_OPERACAO
                                FROM TB_OPERACOESFINANC
                                [WHERE]
                                AND FK_USUARIO = @FK_USUARIO
                                ORDER BY DT_LANCTO";

                sql.AddParametro("@FK_USUARIO", idUser);

                if (!param.Equals(""))
                {
                    query = query.Replace("[WHERE]", param);
                }
                else
                {
                    query = query.Replace("[WHERE]", "");
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

        #region Relatório de Fluxo de caixa
        public DataSet CarregarFluxoCaixa(int idUser, string param = "", string param2 = "")
        {

            try
            {
                DataSet table = new DataSet();

                #region consultar lancamentos
                string query = @"SELECT 
                                 DT_LANCTO,
                                 DS_LANCTO,
                                 TP_OPERACAO,
                                 COALESCE(CASE WHEN TP_OPERACAO = 'C' THEN VL_LANCTO END,0) AS VL_ENTRADA,
                                 COALESCE(CASE WHEN TP_OPERACAO = 'D' THEN (VL_LANCTO) * (-1) END,0) AS VL_SAIDA
                                 FROM TB_OPERACOESFINANC
                                    [WHERE]
                                    AND FK_USUARIO = @FK_USUARIO
                                 ORDER BY DT_LANCTO";

                sql.AddParametro("@FK_USUARIO", idUser);

                if (!param.Equals(""))
                {
                    query = query.Replace("[WHERE]", param);
                }
                else
                {
                    query = query.Replace("[WHERE]", "");
                }

                table.Tables.Add(sql.ExecutarConsulta(query));

                #endregion

                #region consultar saldo
                string query2 = @"SELECT
                                    CAST('SALDO INICIAL' AS char(20)) AS DS_CONTA,
                                    COALESCE(SUM(CASE WHEN FIN.TP_OPERACAO ='D' THEN 0-ABS(FIN.VL_LANCTO) ELSE ABS(FIN.VL_LANCTO) END),0) AS VL_SALDO
                                FROM TB_CONTAS CON
                                LEFT JOIN TB_OPERACOESFINANC AS FIN ON FIN.FK_CONTA = CON.DS_CODIGO
                                    [WHERE]
                                    AND FIN.FK_USUARIO = @FK_USUARIO
                                GROUP BY DS_CONTA";

                sql.AddParametro("@FK_USUARIO", idUser);

                if (!param.Equals(""))
                {
                    query2 = query2.Replace("[WHERE]", param2);
                }
                else
                {
                    query2 = query2.Replace("[WHERE]", "");
                }

                table.Tables.Add(sql.ExecutarConsulta(query2));

                #endregion

                return table;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        #endregion

    }
}