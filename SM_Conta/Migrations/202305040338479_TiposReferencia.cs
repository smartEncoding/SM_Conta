namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TiposReferencia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modulos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 60),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, unique: true, name: "Indice_Modulos_Nombre");
            
            CreateTable(
                "dbo.Tipos_referencia",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 3),
                        Nombre = c.String(maxLength: 60),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Modulos", "Indice_Modulos_Nombre");
            DropTable("dbo.Tipos_referencia");
            DropTable("dbo.Modulos");
        }
    }
}
