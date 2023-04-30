using System;
using System.Collections.Generic;

namespace SM_Conta.Models
{
    
    public partial class Banco
    {
        public short Codigo { get; set; }
        public string Nombre { get; set; }
        public Nullable<bool> Tarjeta { get; set; }
        public Boolean Activo { get; set; }
    }
}
