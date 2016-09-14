namespace PesquisaEleitoral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Admin", c => c.Boolean(nullable: false));
            DropColumn("dbo.Usuarios", "Active");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "Active", c => c.Boolean(nullable: false));
            DropColumn("dbo.Usuarios", "Admin");
        }
    }
}
