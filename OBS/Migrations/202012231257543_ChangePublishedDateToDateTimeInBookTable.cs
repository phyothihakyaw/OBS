namespace OBS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePublishedDateToDateTimeInBookTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "PublishedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Book", "PublishedYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Book", "PublishedYear", c => c.Int(nullable: false));
            DropColumn("dbo.Book", "PublishedDate");
        }
    }
}
