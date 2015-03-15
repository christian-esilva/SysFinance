using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SysFinance.DAL;
using SysFinance.DTO;

namespace SysFinance.BLL
{
    public class ContaBLL
    {
        ContaDAL obj = new ContaDAL();

        #region incluir conta
        public void Incluir(ContaDTO conta)
        {

            obj.Incluir(conta);
        }
        #endregion

        #region excluir conta
        public void Excluir(int id)
        {
            obj.Excluir(id);
        }
        #endregion

        #region verificar exclusao de conta
        public bool VerificarExclusao(int id)
        {

            if (!obj.verifExclusao(id))
            {
                return false;
            }

            Excluir(id);
            return true;
        }
        #endregion

        #region alterar conta
        public void Alterar(ContaDTO conta)
        {
            obj.Alterar(conta);
        }
        #endregion

        #region Carregar grade de contas
        public DataTable CarregaGrade(int idUser, string param = "")
        {
            return obj.ListarContas(idUser, param);
        }
        #endregion

        #region verificar campo de conta
        public bool verifCampo(string valor, int idUser)
        {
            return obj.verifCampo(valor, idUser);
        }
        #endregion

    }
}
