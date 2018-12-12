namespace ECommerceDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsFeatured : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ImageURL", c => c.String());
            AddColumn("dbo.Categories", "IsFeatured", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "IsFeatured");
            DropColumn("dbo.Categories", "ImageURL");
        }
    }
}
