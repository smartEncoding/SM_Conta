using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM_Conta.Models
{
    [Table("Sucursales")]
    public class Sucursal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [DefaultValue(0)]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        [DefaultValue(false)]
        public bool Usa_Exento { get; set; }
        [DefaultValue(false)]
        public bool Usa_F_Mixt { get; set; }

        [DefaultValue(0)]
        public Nullable<int> Imp_2_Cat { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Hon_X_Pag { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Esp_Petr { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cred_Iva { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Deb_Iva { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Ret_Iva { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Esp_Benc { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_Clte { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_Pro { get; set; }
        [DefaultValue(0)]
        public Nullable<int> caja { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_Bol { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_I_Clte { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_I_Prov { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_COMBUS { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_I_HONO { get; set; }
        
        public string Membrete { get; set; }
        public string Domicilio { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_P_BOL { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_PPM { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_DL910 { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Ch_CARTERA { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_EFECT { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Ch_X_PAGAR { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_ICARNE { get; set; }
        
        public string Dir_IMPORT { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Cta_Fepp { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Antic_Cltes { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Antic_Prove { get; set; }
        [DefaultValue(0)]
        public Nullable<int> Imp_no_Rec { get; set; }
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        [DefaultValue(true)]
        public bool Activo { get; set; }
    }
}
