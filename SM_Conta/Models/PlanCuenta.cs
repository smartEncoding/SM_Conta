using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SM_Conta.Models
{
    public class PlanCuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_plan_cta { get; set; }
        public int Anio { get; set; }

        [Required(ErrorMessage = "El campo {0} no debe estar en blanco")]

        [Index("Indice_PlanCta_Cuenta", IsUnique = true)] 
        public int Cuenta { get; set; }

        [Required(ErrorMessage = "El campo {0} no debe estar en blanco")]

        [Index("Indice_PlanCta_Nombre", IsUnique = false)]
        [StringLength(60, ErrorMessage = "El {0} no debe tener entre {1} y {2} caracteres", MinimumLength = 3)] 
        public string Nombre { get; set; }
        public int Pertence { get; set; }
        
        [DefaultValue(false)] 
        public Boolean Principal { get; set; }
        
        [DefaultValue(false)] 
        public Boolean Analisis { get; set; }
        
        [DefaultValue(false)] 
        public Boolean Capital  { get; set; }

        [DefaultValue(false)] 
        public Boolean Cons_Banc { get; set; }

        [DefaultValue(0)] 
        public int T_analisi { get; set; }
        
        [DefaultValue(0)] 
        public int Est_Resu { get; set; }
        
        [DefaultValue(false)] 
        public Boolean Es_Pago { get; set; }
        
        public int Nivel { get; set; }
        public int Tipo { get; set; }

        [DefaultValue(false)]
        public Boolean CapPropio { get; set; }

        [DefaultValue(false)]
        public Boolean ActFijo { get; set; }

        [DefaultValue(false)]
        public Boolean Cp_ActNorm { get; set; }

        [DefaultValue(false)]
        public Boolean Cp_Into { get; set; }

        [DefaultValue(false)]
        public Boolean Cp_Complem { get; set; }

        [DefaultValue(false)]
        public Boolean Cp_PasExig { get; set; }


    }
}