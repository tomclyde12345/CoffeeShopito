namespace CoffeeShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerMigrations : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AddressModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AddressModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        Street = c.String(),
                        HouseNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
