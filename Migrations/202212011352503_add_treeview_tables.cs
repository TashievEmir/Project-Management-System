namespace Project_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_treeview_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrGorevlers",
                c => new
                    {
                        PrGorevlerId = c.Int(nullable: false, identity: true),
                        gorKmTas = c.String(),
                        gorev = c.String(),
                        gorev2 = c.String(),
                    })
                .PrimaryKey(t => t.PrGorevlerId);
            
            CreateTable(
                "dbo.ProjectKmTas",
                c => new
                    {
                        prKmTasId = c.Int(nullable: false, identity: true),
                        prName = c.String(),
                        kmTas = c.String(),
                        kmTas2 = c.String(),
                    })
                .PrimaryKey(t => t.prKmTasId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProjectKmTas");
            DropTable("dbo.PrGorevlers");
        }
    }
}
