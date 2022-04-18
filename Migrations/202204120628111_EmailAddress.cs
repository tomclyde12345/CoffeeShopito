namespace CoffeeShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "EmailAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "EmailAddress");
        }
    }
}
