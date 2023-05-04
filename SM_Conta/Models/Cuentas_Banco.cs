using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models
{

    public class Cuentas_Banco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Banco { get; set; }
        public string Cta_ctble { get; set; }
        public string Bco_cta { get; set; }

        [DefaultValue(true)]
        public bool Activo { get; set; }
        
        [DefaultValue(0)]
        public Nullable<int> Fk_Codigo_Banco { get; set; }
    }
}
