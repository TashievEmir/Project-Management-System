namespace Project_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonProject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "PersonProject", c => c.String());
            DropColumn("dbo.People", "Project");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Project", c => c.String());
            DropColumn("dbo.People", "PersonProject");
        }
    }
}
