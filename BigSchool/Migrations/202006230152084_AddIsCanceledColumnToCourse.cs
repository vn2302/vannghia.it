namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanceledColumnToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Courses", "Heading", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Heading");
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
