namespace SM_Conta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSucursales : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sucursales", "Imp_2_Cat", c => c.Int());
            AlterColumn("dbo.Sucursales", "Hon_X_Pag", c => c.Int());
            AlterColumn("dbo.Sucursales", "Esp_Petr", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cred_Iva", c => c.Int());
            AlterColumn("dbo.Sucursales", "Deb_Iva", c => c.Int());
            AlterColumn("dbo.Sucursales", "Ret_Iva", c => c.Int());
            AlterColumn("dbo.Sucursales", "Esp_Benc", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_Clte", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_Pro", c => c.Int());
            AlterColumn("dbo.Sucursales", "caja", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_Bol", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_I_Clte", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_I_Prov", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_COMBUS", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_I_HONO", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_P_BOL", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_PPM", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_DL910", c => c.Int());
            AlterColumn("dbo.Sucursales", "Ch_CARTERA", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_EFECT", c => c.Int());
            AlterColumn("dbo.Sucursales", "Ch_X_PAGAR", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_ICARNE", c => c.Int());
            AlterColumn("dbo.Sucursales", "Cta_Fepp", c => c.Int());
            AlterColumn("dbo.Sucursales", "Antic_Cltes", c => c.Int());
            AlterColumn("dbo.Sucursales", "Antic_Prove", c => c.Int());
            AlterColumn("dbo.Sucursales", "Imp_no_Rec", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sucursales", "Imp_no_Rec", c => c.String());
            AlterColumn("dbo.Sucursales", "Antic_Prove", c => c.String());
            AlterColumn("dbo.Sucursales", "Antic_Cltes", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_Fepp", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_ICARNE", c => c.String());
            AlterColumn("dbo.Sucursales", "Ch_X_PAGAR", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_EFECT", c => c.String());
            AlterColumn("dbo.Sucursales", "Ch_CARTERA", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_DL910", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_PPM", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_P_BOL", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_I_HONO", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_COMBUS", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_I_Prov", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_I_Clte", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_Bol", c => c.String());
            AlterColumn("dbo.Sucursales", "caja", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_Pro", c => c.String());
            AlterColumn("dbo.Sucursales", "Cta_Clte", c => c.String());
            AlterColumn("dbo.Sucursales", "Esp_Benc", c => c.String());
            AlterColumn("dbo.Sucursales", "Ret_Iva", c => c.String());
            AlterColumn("dbo.Sucursales", "Deb_Iva", c => c.String());
            AlterColumn("dbo.Sucursales", "Cred_Iva", c => c.String());
            AlterColumn("dbo.Sucursales", "Esp_Petr", c => c.String());
            AlterColumn("dbo.Sucursales", "Hon_X_Pag", c => c.String());
            AlterColumn("dbo.Sucursales", "Imp_2_Cat", c => c.String());
        }
    }
}
