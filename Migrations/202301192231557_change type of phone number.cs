namespace Project_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetypeofphonenumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "PhoneNumbers", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "PhoneNumbers", c => c.Long(nullable: false));
        }
    }
}
