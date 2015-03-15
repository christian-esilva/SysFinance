using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SysFinance.DAL.Properties;

namespace SysFinance.DAL
{
   public class ConexaoBanco: IDisposable 
    {

        private static SqlConnection connection = null;
        
        #region cria uma conexão com o banco de dados
        public SqlConnection CriaConexao()
        {
            try
            {
                return connection = new SqlConnection(Settings.Default.stringConexao);
            }
            catch (Exception e)
            {
                return connection = null;
                throw new Exception(e.Message);
            }
        }
        #endregion

        #region abre conexao com banco
        public void AbreConexao()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                connection.Close();
                throw new Exception(e.Message);
            }
        }
        #endregion

        #region fechar conexao com banco
        public void FechaConexao()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
        #endregion

        #region disose
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
