namespace OBS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBookAndAuthorRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "AuthorId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "AuthorId");
        }
    }
}
