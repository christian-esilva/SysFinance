using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFinance.DAL;
using SysFinance.DTO;
using SysFinance.BLL;
using System.Data;
using System.Data.SqlClient;

namespace SysFinance.BLL
{
    public class SegmentoBLL
    {

        SegmentoDAL obj = new SegmentoDAL();

        #region incluir segmento
        public void Incluir(SegmentoDTO segmento)
        {
            try
            {
                obj.Incluir(segmento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region exlcuir segmento
        public void Excluir(int id)
        {
            try
            {
                obj.Excluir(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region alterar segmento
        public void Alterar(SegmentoDTO segmento)
        {
            try
            {
                obj.Alterar(segmento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region carregar segmentos
        public DataTable CarregaGrade(string param = "")
        {
            try
            {
                return obj.ListarSegmentos(param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region verificar campo de segmento
        public bool verifCampo(string valor)
        {
            try
            {
                return obj.verifCampo(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
