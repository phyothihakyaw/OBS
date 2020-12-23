namespace OBS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTablesName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Authors", newName: "Author");
            RenameTable(name: "dbo.Categories", newName: "Category");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Category", newName: "Categories");
            RenameTable(name: "dbo.Author", newName: "Authors");
        }
    }
}
