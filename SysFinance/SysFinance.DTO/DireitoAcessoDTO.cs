using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFinance.DTO
{
    public class DireitoAcessoDTO
    {
        public int Pkid { get; set; }
        public int FkUsuario { get; set; }
        public int TgUsuario { get; set; }
        public int TgConta { get; set; }
        public int TgSegmento { get; set; }
        public int TgLancamento { get; set; }
        public int TgFluxoCaixa { get; set; }
        public int TgExtratoConta { get; set; }
    }
}
