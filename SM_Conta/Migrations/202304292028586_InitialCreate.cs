namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        Principal = c.Boolean(nullable: false),
                        Analisis = c.Boolean(nullable: false),
                        Capital = c.Boolean(nullable: false),
                        Cons_Banc = c.Boolean(nullable: false),
                        T_analisi = c.Int(nullable: false),
                        Est_Resu = c.Int(nullable: false),
                        Es_Pago = c.Boolean(nullable: false),
                        Nivel = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        CapPropio = c.Boolean(nullable: false),
                        ActFijo = c.Boolean(nullable: false),
                        Cp_ActNorm = c.Boolean(nullable: false),
                        Cp_Into = c.Boolean(nullable: false),
                        Cp_Complem = c.Boolean(nullable: false),
                        Cp_PasExig = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_plan_cta)
                .Index(t => t.Cuenta, unique: true, name: "Indice_PlanCta_Cuenta")
                .Index(t => t.Nombre, name: "Indice_PlanCta_Nombre");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PlanCuentas", "Indice_PlanCta_Nombre");
            DropIndex("dbo.PlanCuentas", "Indice_PlanCta_Cuenta");
            DropTable("dbo.PlanCuentas");
        }
    }
}
