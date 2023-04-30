using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SM_Conta.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id_Entidad { get; set; }

        /*
        [Index("Indice_Cliente_Rut_c", IsUnique = true)]
        [StringLength(15, ErrorMessage = "El {0} debe tener  {1} caracter", MinimumLength = 6)]
        public string Rut_c { get; set; }
        */
        [Index("Indice_Cliente_Run", IsUnique = true)]
        public int Run { get; set; }
        [StringLength(1, ErrorMessage = "El {0} debe tener  {1} caracter", MinimumLength = 1)]
        public string Dv { get; set; }

        [StringLength(60, ErrorMessage = "El {0} debe tener entre {2} y {1} caracteres", MinimumLength = 6)]
        [Index("Indice_Cliente_RazonSocial", IsUnique = true)]
        [Display(Name = "Razon Social", 
        Prompt = "Ingrese razon Social", Description = "Razon social de Empresa")]
        public string RazonSocial { get; set; }
        public string Fono { get; set; }
        
        [StringLength(60, ErrorMessage = "El {0} debe tener  {1} caracter", MinimumLength = 6)]
        public string Giro { get; set; }

        [StringLength(60, ErrorMessage = "El {0} debe tener  {1} caracter", MinimumLength = 6)]
        public string Contacto { get; set; }
        public string Contacto_Compras { get; set; }
        
        [DefaultValue(false)] 
        public bool Bloq { get; set; }
        [DefaultValue(false)] 
        public Nullable<bool> Bloq_cred { get; set; }
        [DefaultValue(0)] 
        public Nullable<double> Otorgado { get; set; }
        [DefaultValue(0)] 
        public Nullable<int> Vendedor { get; set; }
        public Nullable<System.DateTime> Fecha_crea { get; set; }
        public string Usr_crea { get; set; }
        public bool Activo { get; set; }

    }
}