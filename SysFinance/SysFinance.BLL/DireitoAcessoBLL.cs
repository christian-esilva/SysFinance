using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SysFinance.DAL;
using SysFinance.DTO;
using System.Data.SqlClient;

namespace SysFinance.BLL
{
    public class DireitoAcessoBLL
    {
        DireitoAcessoDAL obj = new DireitoAcessoDAL();
        
        #region carregar direitos de acesso
        public SqlDataReader CarregarDireitos(int codUsuario)
        {
            return obj.CarregarDireitos(codUsuario);
        }
        #endregion

        #region atualizar direitos de acesso
        public void AtualizarDireitos(DireitoAcessoDTO direitos)
        {
            obj.AtualizarDireitos(direitos);
        }
        #endregion

    }
}
