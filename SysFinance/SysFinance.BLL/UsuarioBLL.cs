using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFinance.DTO;
using SysFinance.DAL;
using System.Data;

namespace SysFinance.BLL
{
    public class UsuarioBLL
    {

        UsuarioDAL obj = new UsuarioDAL();

        #region incluir ususario
        public void Incluir(UsuarioDTO usuario)
        {
            obj.Incluir(usuario);
        }
        #endregion

        #region alterar usuario
        public void Alterar(UsuarioDTO usuario)
        {
            obj.Alterar(usuario);
        }
        #endregion

        #region ativar/desativar usuario
        public void AtivarDesativar(UsuarioDTO usuario)
        {
            obj.AtivarDesativar(usuario);
        }
        #endregion

        #region carregar usuarios
        public DataTable CarregaGrade(string param = "")
        {
            return obj.ListarUsuarios(param);
        }
        #endregion

        #region autenticar login no sistema
        public UsuarioDTO AutenticaLogin(UsuarioDTO usuario)
        {
            return obj.AutenticaLogin(usuario);
        }
        #endregion

        #region trocar senha de usuario
        public void TrocarSenha(UsuarioDTO usuario)
        {
            obj.TrocarSenha(usuario);
        }
        #endregion

        #region verificar campo de usuario
        public bool verifCampo(string valor)
        {
            return obj.verifCampo(valor);
        }
        #endregion

        #region desabilitar autoajuda
        public void AtivarDesativarAutoAjuda(UsuarioDTO usuario)
        {
            obj.AtivarDesativarAutoAjuda(usuario);
        }
        #endregion


    }
}
