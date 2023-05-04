using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models
{
    
    public class Tipos_referencia
    {
        [Key]
        [StringLength(3, ErrorMessage = "El {0} debe tener entre {1} y {2} caracteres", MinimumLength = 1)]
        public string Codigo { get; set; }
        
        [StringLength(60, ErrorMessage = "El {0} no debe tener entre {1} y {2} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; }

        [DefaultValue(true)]
        public bool Activo { get; set; }
    }
}
