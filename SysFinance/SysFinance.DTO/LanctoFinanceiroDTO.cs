using System;

namespace SysFinance.DTO
{
    public class LanctoFinanceiroDTO
    {
        public int PkId { get; set; }
        public string FkConta { get; set; }
        public int FkSegmento { get; set; }
        public int FkUsuario { get; set; }
        public string DsLancto { get; set; }
        public DateTime DtLancto { get; set; }
        public double VlLancto { get; set; }
        public char TpOperacao { get; set; }
        public string DsObs { get; set; }
    }
}
