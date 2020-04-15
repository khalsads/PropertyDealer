namespace PropertyDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1tomanylinkforaddressmodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Provinces", "Country_CountryId", "dbo.Countries");
            DropIndex("dbo.Provinces", new[] { "Country_CountryId" });
            DropColumn("dbo.Provinces", "Country_CountryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Provinces", "Country_CountryId", c => c.Int());
            CreateIndex("dbo.Provinces", "Country_CountryId");
            AddForeignKey("dbo.Provinces", "Country_CountryId", "dbo.Countries", "CountryId");
        }
    }
}
