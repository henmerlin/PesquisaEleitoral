namespace PesquisaEleitoral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Oi : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Usuarios", name: "Voto_Id", newName: "VotoId");
            RenameIndex(table: "dbo.Usuarios", name: "IX_Voto_Id", newName: "IX_VotoId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Usuarios", name: "IX_VotoId", newName: "IX_Voto_Id");
            RenameColumn(table: "dbo.Usuarios", name: "VotoId", newName: "Voto_Id");
        }
    }
}
