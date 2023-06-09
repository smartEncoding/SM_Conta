using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models
{
    
    public class Centro_Costo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Index("Indice_CentrosCostos_Nombre", IsUnique = true)]
        [StringLength(60, ErrorMessage = "El {0} no debe tener entre {1} y {2} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; }

        [DefaultValue(true)]
        public Nullable<bool> Activo { get; set; }
    }
}
