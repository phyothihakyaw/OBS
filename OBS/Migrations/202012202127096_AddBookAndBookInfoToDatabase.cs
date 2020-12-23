namespace OBS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookAndBookInfoToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookInfo",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Cover = c.Binary(nullable: false),
                        File = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Book", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        PublishedYear = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookInfo", "Id", "dbo.Book");
            DropIndex("dbo.BookInfo", new[] { "Id" });
            DropTable("dbo.Book");
            DropTable("dbo.BookInfo");
        }
    }
}
