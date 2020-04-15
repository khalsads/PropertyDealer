namespace PropertyDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomermodeland1tomannyrelationtoaddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        AdrsStreet = c.String(),
                        Adrs_AdrsId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Adrs", t => t.Adrs_AdrsId)
                .Index(t => t.Adrs_AdrsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Adrs_AdrsId", "dbo.Adrs");
            DropIndex("dbo.Customers", new[] { "Adrs_AdrsId" });
            DropTable("dbo.Customers");
        }
    }
}
