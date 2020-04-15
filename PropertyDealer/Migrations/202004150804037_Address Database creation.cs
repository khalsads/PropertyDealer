namespace PropertyDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressDatabasecreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adrs",
                c => new
                    {
                        AdrsId = c.Int(nullable: false, identity: true),
                        AdrsStreet = c.String(),
                        PostalCode = c.String(),
                        CityName = c.String(),
                        ProvinceName = c.String(),
                        CountryName = c.String(),
                        City_CityId = c.Int(),
                        Country_CountryId = c.Int(),
                        Province_ProvinceId = c.Int(),
                    })
                .PrimaryKey(t => t.AdrsId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceId)
                .Index(t => t.City_CityId)
                .Index(t => t.Country_CountryId)
                .Index(t => t.Province_ProvinceId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceId = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                        Country_CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProvinceId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .Index(t => t.Country_CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adrs", "Province_ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Adrs", "Country_CountryId", "dbo.Countries");
            DropForeignKey("dbo.Provinces", "Country_CountryId", "dbo.Countries");
            DropForeignKey("dbo.Adrs", "City_CityId", "dbo.Cities");
            DropIndex("dbo.Provinces", new[] { "Country_CountryId" });
            DropIndex("dbo.Adrs", new[] { "Province_ProvinceId" });
            DropIndex("dbo.Adrs", new[] { "Country_CountryId" });
            DropIndex("dbo.Adrs", new[] { "City_CityId" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Adrs");
        }
    }
}
