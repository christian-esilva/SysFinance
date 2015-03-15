using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace's que contém as classes que manipulam dados
using System.Data;
using System.Data.SqlClient;
using SysFinance.DAL.Properties;

namespace SysFinance.DAL
{
    public class AcessoDados
    {
        SqlCommand sqlCommand;
        static ConexaoBanco connection = new ConexaoBanco();

        //coleção de parametros que vão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        #region limpar parametros de querys, inserts, updates e deletes
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }
        #endregion

        #region adicionar parametros em querys, inserts, updates e deletes
        public void AddParametro(string nomeParametro, object valorParametro)
        { 
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        #endregion

        #region persistência dos dados (inserir, alterar, excluir) ExecuteSQL : ExecuteScalar
        public object ExecuteSql(string sql)
        {
            try
            {
                //comandos para o banco
                sqlCommand = connection.CriaConexao().CreateCommand();

                //abre a conexão
                connection.AbreConexao();

                //sqlCommand.CommandType = commandType; //o tipo pode ser um texto ou uma procedure, de acordo com o parametro passado
                sqlCommand.CommandText = sql;
                //sqlCommand.CommandTimeout = 7200; //em segundos
                sqlCommand.CommandTimeout = 60; //em segundos

                //passa os parametros para o comando sql
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally 
            {
                LimparParametros();
                connection.FechaConexao();
            }

        }
        #endregion

        #region consulta de registros(SELECT'S)
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                //comandos para o banco
                sqlCommand = connection.CriaConexao().CreateCommand();

                //abre a conexão
                connection.AbreConexao();

                sqlCommand.CommandText = sql;
                sqlCommand.CommandTimeout = 60; //em segundos

                //passa os parametros para o comando sql
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //cria um adpatador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //tabela de dados vazia onde ficará os dados e o adaptador preencher o dataTable
                DataTable dataTable = new DataTable();

                //comando para buscar os dados no banco e o adaptador preenche o dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                LimparParametros();
                connection.FechaConexao();
            }
        }
        #endregion

        #region Método que retorna um datareader com o resultado da query.
        public SqlDataReader retornaQuery(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                sqlCommand = new SqlCommand(query, connection.CriaConexao());
                
                //Fecha a conexão.
                connection.AbreConexao();

                //passa os parametros para o comando sql
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executa a query sql.
                SqlDataReader retornaQuery = sqlCommand.ExecuteReader();

                //Fecha a conexão.
                //connection.FechaConexao();

                //Retorna o dataReader com o resultado
                return retornaQuery;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                //Fecha a conexão.
               // connection.AbreConexao();
                LimparParametros();
            }

        }
        #endregion

        #region Método que retorna o resultado da consulta sql em um dataset
        public DataSet retornaQueryDataSet(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand sqlCommand = new SqlCommand(query, connection.CriaConexao());

                //Instância o sqldataAdapter.
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                //Instância o dataSet de retorno.
                DataSet dataSet = new DataSet();

                //Atualiza o dataSet
                adapter.Fill(dataSet);

                //Retorna o dataSet com o resultado da query sql.
                return dataSet;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion

        #region executa query sem retorno : ExecuteNonQuery
        public void executaQuery(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                sqlCommand = new SqlCommand(query, connection.CriaConexao());

                connection.AbreConexao();

                //passa os parametros para o comando sql
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executa a query sql.
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                LimparParametros();
                connection.FechaConexao();
            }
        }
        #endregion

        #region Método que executa a query sql e retorna o identity: ExecuteScalar
        public int executaQueryIdentity(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                sqlCommand = new SqlCommand(query, connection.CriaConexao());
                
                //abre a conexão
                connection.AbreConexao();

                //passa os parametros para o comando sql
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                sqlCommand.CommandText = query;

                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                LimparParametros();
                connection.FechaConexao();
            }
        }
        #endregion
    }
}
