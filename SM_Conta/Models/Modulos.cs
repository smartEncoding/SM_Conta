using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models

{
    
    public  class Modulos
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Index("Indice_Modulos_Nombre", IsUnique = true)]
        [StringLength(60, ErrorMessage = "El {0} debe tener entre {1} y {2} caracteres", MinimumLength = 3)] 
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
