namespace Project_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updates2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrStatus",
                c => new
                    {
                        statusId = c.Int(nullable: false, identity: true),
                        statusName = c.String(),
                    })
                .PrimaryKey(t => t.statusId);
            
            AlterColumn("dbo.Projects", "Manager", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "Status", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "PrType", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "Manager");
            CreateIndex("dbo.Projects", "Status");
            CreateIndex("dbo.Projects", "PrType");
            AddForeignKey("dbo.Projects", "Manager", "dbo.People", "PersonId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "Status", "dbo.PrStatus", "statusId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "PrType", "dbo.ProjectTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "PrType", "dbo.ProjectTypes");
            DropForeignKey("dbo.Projects", "Status", "dbo.PrStatus");
            DropForeignKey("dbo.Projects", "Manager", "dbo.People");
            DropIndex("dbo.Projects", new[] { "PrType" });
            DropIndex("dbo.Projects", new[] { "Status" });
            DropIndex("dbo.Projects", new[] { "Manager" });
            AlterColumn("dbo.Projects", "PrType", c => c.String());
            AlterColumn("dbo.Projects", "Status", c => c.String());
            AlterColumn("dbo.Projects", "Manager", c => c.String());
            DropTable("dbo.PrStatus");
        }
    }
}
