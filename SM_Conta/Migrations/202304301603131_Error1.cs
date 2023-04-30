namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Error1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Sucursals", newName: "Sucursales");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Sucursales", newName: "Sucursals");
        }
    }
}
