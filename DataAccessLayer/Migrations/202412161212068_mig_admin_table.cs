namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_admin_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminUserName = c.String(nullable: false, maxLength: 50),
                        AdminPassword = c.String(nullable: false, maxLength: 255),
                        AdminEmail = c.String(nullable: false, maxLength: 100),
                        AdminRole = c.String(nullable: false, maxLength: 30),
                        ProfileImage = c.String(maxLength: 255),
                        FullName = c.String(maxLength: 1100),
                    })
                .PrimaryKey(t => t.AdminID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
