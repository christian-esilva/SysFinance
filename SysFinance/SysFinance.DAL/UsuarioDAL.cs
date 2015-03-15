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
    public class UsuarioDAL
    {
        //public ConexaoBanco Conexao { get; set; }

        AcessoDados sql = new AcessoDados();

        #region incluir novo usuario
        public void Incluir(UsuarioDTO usuario)
        {
            try
            {
                //using (Conexao = new ConexaoBanco())
                //{

                sql.AddParametro("@DS_NOME", usuario.DsNome);
                sql.AddParametro("@DS_SENHA", usuario.DsSenha);
                sql.AddParametro("@DS_EMAIL", usuario.DsEmail);
                sql.AddParametro("@DS_NOMEMAQUINA", usuario.DsNomeMaquina);
                sql.AddParametro("@DS_LOGIN", usuario.DsLogin);
                sql.AddParametro("@TG_INATIVO", usuario.TgInativo);

                string insert = @"INSERT INTO TB_USUARIOS (DS_NOME, DS_SENHA, DS_EMAIL, DS_NOMEMAQUINA, DS_LOGIN, TG_INATIVO)
                                  VALUES (@DS_NOME, @DS_SENHA, @DS_EMAIL, @DS_NOMEMAQUINA, @DS_LOGIN, @TG_INATIVO) SELECT SCOPE_IDENTITY()";

                usuario.IdUsuario = Convert.ToInt32(sql.ExecuteSql(insert));

                string insertDireito = "INSERT INTO TB_DIREITOUSUARIOS (FK_USUARIO) VALUES (@FK_USUARIO)";

                sql.AddParametro("@FK_USUARIO", usuario.IdUsuario);

                sql.ExecuteSql(insertDireito);
                //}
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

        #region alterar usuario
        public void Alterar(UsuarioDTO usuario)
        {
            // conexao
            //connection.CriaConexao();
            try
            {
                sql.AddParametro("@PK_ID", usuario.IdUsuario);
                sql.AddParametro("@DS_NOME", usuario.DsNome);
                sql.AddParametro("@DS_EMAIL", usuario.DsEmail);
                sql.AddParametro("@DS_LOGIN", usuario.DsLogin);
                sql.AddParametro("@TG_INATIVO", usuario.TgInativo);

                string update = @"UPDATE TB_USUARIOS SET DS_NOME = @DS_NOME, DS_EMAIL = @DS_EMAIL,
                                  DS_LOGIN = @DS_LOGIN, TG_INATIVO = @TG_INATIVO WHERE PK_ID = @PK_ID";
                
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

        #region trocar senha
        public void TrocarSenha(UsuarioDTO usuario)
        {
            // conexao
            //connection.CriaConexao();
            try
            {
                sql.AddParametro("@PK_ID", usuario.IdUsuario);
                sql.AddParametro("@DS_SENHA", usuario.DsSenha);

                string update = "UPDATE TB_USUARIOS SET DS_SENHA = @DS_SENHA WHERE PK_ID = @PK_ID";

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

        #region ativar/desativar usuario
        public void AtivarDesativar(UsuarioDTO usuario)
        {

            try
            {
                usuario.TgInativo = usuario.TgInativo == 0 ? 1 : 0;

                sql.AddParametro("@PK_ID", usuario.IdUsuario);
                sql.AddParametro("@TG_INATIVO", usuario.TgInativo);
                string update = "UPDATE TB_USUARIOS SET TG_INATIVO = @TG_INATIVO WHERE PK_ID = @PK_ID";
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

        #region ativar/desativar autoajuda
        public void AtivarDesativarAutoAjuda(UsuarioDTO usuario) {
            try
            {
                sql.AddParametro("@PK_ID", usuario.IdUsuario);
                sql.AddParametro("@TG_AUTOAJUDA", usuario.TgAutoAjuda);
                string update = "UPDATE TB_USUARIOS SET TG_AUTOAJUDA = @TG_AUTOAJUDA WHERE PK_ID = @PK_ID";
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

        #region autenticar login de usuario do sistema
        public UsuarioDTO AutenticaLogin(UsuarioDTO usuario)
        {
            try
            {
                String query = @"SELECT PK_ID, COALESCE(DS_NOME,'') AS DS_NOME, TG_AUTOAJUDA FROM TB_USUARIOS
                                 WHERE DS_LOGIN = @DS_LOGIN
                                 AND DS_SENHA = @DS_SENHA
                                 AND TG_INATIVO = 0";

                sql.AddParametro("@DS_LOGIN", usuario.DsLogin);
                sql.AddParametro("@DS_SENHA", usuario.DsSenha);

                SqlDataReader reader = sql.retornaQuery(query);

                reader.Read();
                usuario.IdUsuario     = (int)reader[0];
                usuario.DsNome        = (string)reader[1];
                usuario.TgAutoAjuda = Convert.ToInt32(reader[2]);
                usuario.DsNomeMaquina = (string)System.Environment.MachineName;

                UpdateMaquina(usuario);

                return usuario;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }
        #endregion

        #region atualizar maquina de utilização do sistema
        public void UpdateMaquina(UsuarioDTO usuario)
        {
            try
            {

                string query = "UPDATE TB_USUARIOS SET DS_NOMEMAQUINA = @DS_NOMEMAQUINA WHERE PK_ID = @PK_ID";

                sql.AddParametro("@DS_NOMEMAQUINA", usuario.DsNomeMaquina.Trim().ToUpper());
                sql.AddParametro("@PK_ID", usuario.IdUsuario);

                sql.executaQuery(query);
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

        #region carregar usuarios
        public DataTable ListarUsuarios(string param)
        {
            try
            {
                string query = "SELECT PK_ID, DS_NOME, DS_LOGIN, DS_EMAIL, DS_NOMEMAQUINA, DS_SENHA, COALESCE(TG_INATIVO,0) AS TG_INATIVO  FROM TB_USUARIOS " ;

                if (!param.Equals(""))
                {
                    query += param;
                }
                
                query += " ORDER BY DS_NOME";

                DataTable table = sql.ExecutarConsulta(query);

                return table;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion

        #region verificar usuario
        public bool verifCampo(string valor)
        {
            string query = "SELECT PK_ID FROM TB_USUARIOS WHERE DS_LOGIN = @DS_LOGIN";

            sql.AddParametro("@DS_LOGIN", valor);

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
