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
    public class ContaDAL
    {
        AcessoDados sql = new AcessoDados();

        #region incluir nova conta
        public void Incluir(ContaDTO conta)
        {
            try
            {
                sql.AddParametro("@DS_CODIGO", conta.DsCodigo);
                sql.AddParametro("@FK_USUARIO", conta.IdUsuario);
                sql.AddParametro("@DS_CONTA", conta.DsConta);

                string insert = @"INSERT INTO TB_CONTAS (DS_CODIGO, FK_USUARIO, DS_CONTA)
                                  VALUES (@DS_CODIGO, @FK_USUARIO, @DS_CONTA)";

                conta.IdConta = Convert.ToInt32(sql.ExecuteSql(insert));
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

        #region alterar contas
        public void Alterar(ContaDTO conta)
        {
            try
            {
                sql.AddParametro("@PK_ID", conta.IdConta);
                sql.AddParametro("@DS_CODIGO", conta.DsCodigo);
                sql.AddParametro("@DS_CONTA", conta.DsConta);

                string update = "UPDATE TB_CONTAS SET DS_CODIGO = @DS_CODIGO, DS_CONTA = @DS_CONTA WHERE PK_ID = @PK_ID";
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

        #region exluir contas
        public void Excluir(int id)
        {
            try
            {
                sql.AddParametro("@PK_ID", id);
                string delete = "DELETE FROM TB_CONTAS WHERE PK_ID = @PK_ID";
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

        #region carregar contas
        public DataTable ListarContas(int idUser, string param)
        {
            try
            {
                sql.AddParametro("@FK_USUARIO", idUser);


                string query = "SELECT PK_ID, DS_CODIGO, DS_CONTA FROM TB_CONTAS WHERE FK_USUARIO = @FK_USUARIO ";

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

        #region verificar contas
        public bool verifCampo(string valor, int idUser)
        {
            string query = "SELECT DS_CODIGO FROM TB_CONTAS WHERE DS_CODIGO = @DS_CODIGO AND FK_USUARIO = @FK_USUARIO";

            sql.AddParametro("@DS_CODIGO", valor);
            sql.AddParametro("@FK_USUARIO", idUser);

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

        #region verificar exlusao de conta
        public bool verifExclusao(int idConta)
        {

            string query = @"SELECT COUNT(*) FROM TB_OPERACOESFINANC WHERE FK_CONTA = (SELECT DS_CODIGO FROM TB_CONTAS WHERE PK_ID = @PK_ID)";

            sql.AddParametro("@PK_ID", idConta);

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
