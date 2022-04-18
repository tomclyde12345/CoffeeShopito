namespace CoffeeShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "age");
        }
    }
}
