namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlanCuentas",
                c => new
                    {
                        Id_plan_cta = c.Int(nullable: false, identity: true),
                        Anio = c.Int(nullable: false),
                        Cuenta = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Pertence = c.Int(nullable: false),
                        Principal = c.Boolean(nullable: false, defaultValue: false),
                        Analisis = c.Boolean(nullable: false, defaultValue: false),
                        Capital = c.Boolean(nullable: false, defaultValue: false),
                        Cons_Banc = c.Boolean(nullable: false, defaultValue: false),
                        T_analisi = c.Int(nullable: false),
                        Est_Resu = c.Int(nullable: false),
                        Es_Pago = c.Boolean(nullable: false, defaultValue: false),
                        Nivel = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        CapPropio = c.Boolean(nullable: false, defaultValue: false),
                        ActFijo = c.Boolean(nullable: false, defaultValue: false),
                        Cp_ActNorm = c.Boolean(nullable: false, defaultValue: false),
                        Cp_Into = c.Boolean(nullable: false, defaultValue: false),
                        Cp_Complem = c.Boolean(nullable: false, defaultValue: false),
                        Cp_PasExig = c.Boolean(nullable: false, defaultValue: false),
                    })
                .PrimaryKey(t => t.Id_plan_cta)
                .Index(t => t.Cuenta, unique: true, name: "Indice_PlanCta_Cuenta")
                .Index(t => t.Nombre, name: "Indice_PlanCta_Nombre");
            
            CreateTable(
                "dbo.Sucursales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false,defaultValue:0),
                        Nombre = c.String(),
                        Ciudad = c.String(),
                        Usa_Exento = c.Boolean(nullable: false, defaultValue: true),
                        Usa_F_Mixt = c.Boolean(nullable: false, defaultValue: true),
                    Imp_2_Cat = c.Int(defaultValue:0),
                        Hon_X_Pag = c.Int(defaultValue: 0),
                        Esp_Petr = c.Int(defaultValue: 0),
                        Cred_Iva = c.Int(defaultValue: 0),
                        Deb_Iva = c.Int(defaultValue: 0),
                        Ret_Iva = c.Int(defaultValue: 0),
                        Esp_Benc = c.Int(defaultValue: 0),
                        Cta_Clte = c.Int(defaultValue: 0),
                        Cta_Pro = c.Int(defaultValue: 0),
                        caja = c.Int(defaultValue: 0),
                        Cta_Bol = c.Int(defaultValue: 0),
                        Cta_I_Clte = c.Int(defaultValue: 0),
                        Cta_I_Prov = c.Int(defaultValue: 0),
                        Cta_COMBUS = c.Int(defaultValue: 0),
                        Cta_I_HONO = c.Int(defaultValue: 0),
                        Membrete = c.String(),
                        Domicilio = c.String(),
                        Cta_P_BOL = c.Int(defaultValue: 0),
                        Cta_PPM = c.Int(defaultValue: 0),
                        Cta_DL910 = c.Int(defaultValue: 0),
                        Ch_CARTERA = c.Int(defaultValue: 0),
                        Cta_EFECT = c.Int(defaultValue: 0),
                        Ch_X_PAGAR = c.Int(defaultValue: 0),
                        Cta_ICARNE = c.Int(defaultValue: 0),
                        Dir_IMPORT = c.String(),
                        Cta_Fepp = c.Int(defaultValue: 0),
                        Antic_Cltes = c.Int(defaultValue: 0),
                        Antic_Prove = c.Int(defaultValue: 0),
                        Imp_no_Rec = c.Int(defaultValue: 0),
                        Direccion = c.String(),
                        Comuna = c.String(),
                        Activo = c.Boolean(nullable: false, defaultValue: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PlanCuentas", "Indice_PlanCta_Nombre");
            DropIndex("dbo.PlanCuentas", "Indice_PlanCta_Cuenta");
            DropTable("dbo.Sucursales");
            DropTable("dbo.PlanCuentas");
        }
    }
}
