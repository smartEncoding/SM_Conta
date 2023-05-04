using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models
{

    [Table("Bancos")]
    public class Banco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }

        [Index("Indice_Banco_Nombre", IsUnique = true)]
        [StringLength(60, ErrorMessage = "El {0} no debe tener entre {1} y {2} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; }

        [DefaultValue(false)]
        public Nullable<bool> Tarjeta { get; set; }
        
        [DefaultValue(true)]
        public Boolean Activo { get; set; }
    }
}
