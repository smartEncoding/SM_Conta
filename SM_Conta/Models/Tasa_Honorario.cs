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
        public int Id { get; set; }

        [DefaultValue(0)] 
        public double Tasa { get; set; }

        [Index("Indice_Tasa_Honor_Anio", IsUnique = true)]
        public int Anio { get; set; }
    }
}
