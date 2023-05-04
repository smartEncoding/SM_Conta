using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models
{

    public class Tasa_PPm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Nullable<int> Anio { get; set; }
        [DefaultValue(0)]
        public double M1 { get; set; }
        [DefaultValue(0)]
        public double M2 { get; set; }
        [DefaultValue(0)]
        public double M3 { get; set; }
        [DefaultValue(0)]
        public double M4 { get; set; }
        [DefaultValue(0)]
        public double M5 { get; set; }
        [DefaultValue(0)]
        public double M6 { get; set; }
        [DefaultValue(0)]
        public double M7 { get; set; }
        [DefaultValue(0)]
        public double M8 { get; set; }
        [DefaultValue(0)]
        public double M9 { get; set; }
        [DefaultValue(0)]
        public double M10 { get; set; }
        [DefaultValue(0)]
        public double M11 { get; set; }
        [DefaultValue(0)]
        public double M12 { get; set; }
        [DefaultValue(0)]
        public double P1 { get; set; }
        [DefaultValue(0)]
        public double P2 { get; set; }
        [DefaultValue(0)]
        public double P3 { get; set; }
        [DefaultValue(0)]
        public double P4 { get; set; }
        [DefaultValue(0)]
        public double P5 { get; set; }
        [DefaultValue(0)]
        public double P6 { get; set; }
        [DefaultValue(0)]
        public double P7 { get; set; }
        [DefaultValue(0)]
        public double P8 { get; set; }
        [DefaultValue(0)]
        public double P9 { get; set; }
        [DefaultValue(0)]
        public double P10 { get; set; }
        [DefaultValue(0)]
        public double P11 { get; set; }
        [DefaultValue(0)]
        public double P12 { get; set; }
    }
}
