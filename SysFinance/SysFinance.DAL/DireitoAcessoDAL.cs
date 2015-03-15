using SysFinance.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFinance.DAL
{
    public class DireitoAcessoDAL
    {
        AcessoDados sql = new AcessoDados();

        #region carregar direitos de acesso
        public SqlDataReader CarregarDireitos(int codUsuario){
            
            try
            {
                string query = @"SELECT PK_ID, FK_USUARIO, TG_USUARIO,
                                TG_SEGMENTO, TG_CONTA, TG_LANCAMENTO,
                                TG_FLUXODECAIXA, TG_EXTRATOCONTA FROM TB_DIREITOUSUARIOS
                                WHERE FK_USUARIO = @FK_USUARIO";

                sql.AddParametro("@FK_USUARIO", codUsuario);

                SqlDataReader reader = sql.retornaQuery(query);

                return reader;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }
        #endregion

        #region atualizar direitos de acesso
        public void AtualizarDireitos(DireitoAcessoDTO direitos)
        {
            try
            {
                sql.AddParametro("@PK_ID", direitos.Pkid);
                sql.AddParametro("@TG_USUARIO", direitos.TgUsuario);
                sql.AddParametro("@TG_SEGMENTO", direitos.TgSegmento);
                sql.AddParametro("@TG_CONTA", direitos.TgConta);
                sql.AddParametro("@TG_LANCAMENTO", direitos.TgLancamento);
                sql.AddParametro("@TG_EXTRATOCONTA", direitos.TgExtratoConta);
                sql.AddParametro("@TG_FLUXODECAIXA", direitos.TgFluxoCaixa);
                sql.AddParametro("@FK_USUARIO", direitos.FkUsuario);

                string update = @"UPDATE TB_DIREITOUSUARIOS SET TG_USUARIO = @TG_USUARIO, TG_SEGMENTO = @TG_SEGMENTO,
                                TG_CONTA = @TG_CONTA, TG_LANCAMENTO = @TG_LANCAMENTO,
                                TG_EXTRATOCONTA = @TG_EXTRATOCONTA,TG_FLUXODECAIXA = @TG_FLUXODECAIXA
                                WHERE FK_USUARIO = @FK_USUARIO";

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
    }
}
