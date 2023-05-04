namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bancos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bancos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 60),
                        Tarjeta = c.Boolean(defaultValue:false),
                        Activo = c.Boolean(nullable: false,defaultValue:true),
                    })
                .PrimaryKey(t => t.Codigo)
                .Index(t => t.Nombre, unique: true, name: "Indice_Banco_Nombre");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Bancos", "Indice_Banco_Nombre");
            DropTable("dbo.Bancos");
        }
    }
}
