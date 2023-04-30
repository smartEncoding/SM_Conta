using System;
using System.Collections.Generic;

namespace SM_Conta.Models
{
    
    public class Cuenta_Banco
    {
        public int Id { get; set; }
        public string numero { get; set; }
        public string banco { get; set; }
        public string cta_ctble { get; set; }
        public Nullable<System.DateTime> apertura { get; set; }
        public string moneda { get; set; }
        public byte[] ejecutivo { get; set; }
        public string telefono { get; set; }
        public Nullable<double> sobregiro { get; set; }
        public Nullable<double> sobre_sald { get; set; }
        public string bco_cta { get; set; }
        public Nullable<bool> activo { get; set; }
    }
}
