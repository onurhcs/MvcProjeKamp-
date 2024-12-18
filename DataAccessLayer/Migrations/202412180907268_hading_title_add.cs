namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hading_title_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "Title", c => c.String());
            AddColumn("dbo.Headings", "Description2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Headings", "Description2");
            DropColumn("dbo.Headings", "Title");
        }
    }
}
