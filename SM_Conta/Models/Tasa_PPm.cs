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
        public Nullable<double> m1 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m2 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m3 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m4 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m5 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m6 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m7 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m8 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m9 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m10 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m11 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> m12 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p1 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p2 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p3 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p4 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p5 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p6 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p7 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p8 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p9 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p10 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p11 { get; set; }
        [DefaultValue(0)]
        public Nullable<double> p12 { get; set; }
    }
}
