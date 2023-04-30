using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models
{
    
    public class Tasa_Honorario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [DefaultValue(0)] 
        public Nullable<double> tasa { get; set; }
        public int anio { get; set; }
    }
}
