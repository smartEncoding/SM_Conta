using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models
{
    
    public class Tasa_Utm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Anio { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes01 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes02 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes03 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes04 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes05 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes06 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes07 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes08 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes09 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes10 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes11 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> Mes12 { get; set; }
    }
}
