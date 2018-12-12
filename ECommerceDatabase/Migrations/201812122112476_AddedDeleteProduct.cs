namespace ECommerceDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDeleteProduct : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "ImageURL");
            DropColumn("dbo.Categories", "IsFeatured");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "IsFeatured", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categories", "ImageURL", c => c.String());
        }
    }
}
