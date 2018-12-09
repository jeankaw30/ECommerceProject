namespace ECommerceDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewProdCatgory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category1D", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Category1D");
        }
    }
}
