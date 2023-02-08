namespace Project_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpersonphoneNumandmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "PhoneNumbers", c => c.Long(nullable: false));
            AddColumn("dbo.People", "Mail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Mail");
            DropColumn("dbo.People", "PhoneNumbers");
        }
    }
}
