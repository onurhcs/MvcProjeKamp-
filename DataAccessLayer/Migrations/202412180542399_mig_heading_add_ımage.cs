namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_heading_add_ımage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "Description", c => c.String());
            AddColumn("dbo.Headings", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Headings", "ImageUrl");
            DropColumn("dbo.Headings", "Description");
        }
    }
}
