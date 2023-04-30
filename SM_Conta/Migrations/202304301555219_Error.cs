namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Error : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sucursals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nombre = c.String(),
                        Ciudad = c.String(),
                        Usa_Exento = c.Boolean(nullable: false),
                        Usa_F_Mixt = c.Boolean(nullable: false),
                        Imp_2_Cat = c.String(),
                        Hon_X_Pag = c.String(),
                        Esp_Petr = c.String(),
                        Cred_Iva = c.String(),
                        Deb_Iva = c.String(),
                        Ret_Iva = c.String(),
                        Esp_Benc = c.String(),
                        Cta_Clte = c.String(),
                        Cta_Pro = c.String(),
                        caja = c.String(),
                        Cta_Bol = c.String(),
                        Cta_I_Clte = c.String(),
                        Cta_I_Prov = c.String(),
                        Cta_COMBUS = c.String(),
                        Cta_I_HONO = c.String(),
                        Membrete = c.String(),
                        Domicilio = c.String(),
                        Cta_P_BOL = c.String(),
                        Cta_PPM = c.String(),
                        Cta_DL910 = c.String(),
                        Ch_CARTERA = c.String(),
                        Cta_EFECT = c.String(),
                        Ch_X_PAGAR = c.String(),
                        Cta_ICARNE = c.String(),
                        Dir_IMPORT = c.String(),
                        Cta_Fepp = c.String(),
                        Antic_Cltes = c.String(),
                        Antic_Prove = c.String(),
                        Imp_no_Rec = c.String(),
                        Direccion = c.String(),
                        Comuna = c.String(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sucursals");
        }
    }
}
