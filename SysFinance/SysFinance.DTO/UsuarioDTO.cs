using System;
using System.Collections.Generic;

namespace SysFinance.DTO
{
    public class UsuarioDTO
    {
        
        public int IdUsuario { get; set; }
        public string DsNome { get; set; }
        public string DsSenha { get; set; }
        public string DsEmail { get; set; }
        public string DsNomeMaquina { get; set; }
        public string DsLogin { get; set; }
        public int TgInativo { get; set; }
        public int TgAutoAjuda { get; set; }

    }
}
