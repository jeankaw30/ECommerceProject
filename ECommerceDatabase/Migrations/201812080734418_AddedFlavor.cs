namespace ECommerceDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFlavor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Flavor", c => c.String());
            AddColumn("dbo.Products", "Flavor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Flavor");
            DropColumn("dbo.Categories", "Flavor");
        }
    }
}
