namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TasasVarias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Centro_Costo",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 60),
                        Activo = c.Boolean(defaultValue: true),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, unique: true, name: "Indice_CentrosCostos_Nombre");
            
            CreateTable(
                "dbo.Cuentas_Banco",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(),
                        Banco = c.String(),
                        Cta_ctble = c.String(),
                        Bco_cta = c.String(),
                        Activo = c.Boolean(nullable: false, defaultValue: true),
                        Fk_Codigo_Banco = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasa_Honorario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tasa = c.Double(nullable: false, defaultValue: 0),
                        Anio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Anio, unique: true, name: "Indice_Tasa_Honor_Anio");
            
            CreateTable(
                "dbo.Tasa_PPm",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Anio = c.Int(),
                        M1 = c.Double(nullable: false,defaultValue:0),
                        M2 = c.Double(nullable:false,defaultValue:0),
                        M3 = c.Double(nullable:false,defaultValue:0),
                        M4 = c.Double(nullable:false,defaultValue:0),
                        M5 = c.Double(nullable:false,defaultValue:0),
                        M6 = c.Double(nullable:false,defaultValue:0),
                        M7 = c.Double(nullable:false,defaultValue:0),
                        M8 = c.Double(nullable:false,defaultValue:0),
                        M9 = c.Double(nullable:false,defaultValue:0),
                        M10 = c.Double(nullable:false,defaultValue:0),
                        M11 = c.Double(nullable:false,defaultValue:0),
                        M12 = c.Double(nullable:false,defaultValue:0),
                        P1 = c.Double(nullable:false,defaultValue:0),
                        P2 = c.Double(nullable:false,defaultValue:0),
                        P3 = c.Double(nullable:false,defaultValue:0),
                        P4 = c.Double(nullable:false,defaultValue:0),
                        P5 = c.Double(nullable:false,defaultValue:0),
                        P6 = c.Double(nullable:false,defaultValue:0),
                        P7 = c.Double(nullable:false,defaultValue:0),
                        P8 = c.Double(nullable:false,defaultValue:0),
                        P9 = c.Double(nullable:false,defaultValue:0),
                        P10 = c.Double(nullable:false,defaultValue:0),
                        P11 = c.Double(nullable:false,defaultValue:0),
                        P12 = c.Double(nullable:false,defaultValue:0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasa_Utm",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Anio = c.Int(nullable:false,defaultValue:0),
                        Mes01 = c.Double(defaultValue:0),
                        Mes02 = c.Double(defaultValue: 0),
                        Mes03 = c.Double(defaultValue: 0),
                        Mes04 = c.Double(defaultValue: 0),
                        Mes05 = c.Double(defaultValue: 0),
                        Mes06 = c.Double(defaultValue: 0),
                        Mes07 = c.Double(defaultValue: 0),
                        Mes08 = c.Double(defaultValue: 0),
                        Mes09 = c.Double(defaultValue: 0),
                        Mes10 = c.Double(defaultValue: 0),
                        Mes11 = c.Double(defaultValue: 0),
                        Mes12 = c.Double(defaultValue: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tasa_Honorario", "Indice_Tasa_Honor_Anio");
            DropIndex("dbo.Centro_Costo", "Indice_CentrosCostos_Nombre");
            DropTable("dbo.Tasa_Utm");
            DropTable("dbo.Tasa_PPm");
            DropTable("dbo.Tasa_Honorario");
            DropTable("dbo.Cuentas_Banco");
            DropTable("dbo.Centro_Costo");
        }
    }
}
