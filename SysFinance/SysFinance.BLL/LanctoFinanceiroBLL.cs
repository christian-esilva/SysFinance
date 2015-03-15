using SysFinance.DAL;
using SysFinance.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFinance.BLL
{
    public class LanctoFinanceiroBLL
    {
        LanctoFinanceiroDAL obj = new LanctoFinanceiroDAL();

        public void Incluir(LanctoFinanceiroDTO lancto)
        {
            obj.Incluir(lancto);
        }

        public void Excluir(int id)
        {
            obj.Excluir(id);
        }

        public void Alterar(LanctoFinanceiroDTO lancto)
        {
            obj.Alterar(lancto);
        }

        public DataTable CarregaGrade(int idUser, string param = "")
        {
            return obj.ListarLancamentos(idUser, param);
        }
    }
}
