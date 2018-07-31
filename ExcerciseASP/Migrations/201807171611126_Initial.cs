namespace ExcerciseASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        CustomerId = c.String(nullable: false, maxLength: 5, unicode: false),
                        AddressType = c.String(nullable: false, maxLength: 1, unicode: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Street = c.String(maxLength: 100),
                        ZIP = c.String(maxLength: 20, unicode: false),
                        City = c.String(maxLength: 100),
                        Country = c.String(maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => new { t.CustomerId, t.AddressType })
                .ForeignKey("dbo.AddressTypes", t => t.AddressType)
                .ForeignKey("dbo.Countries", t => t.Country)
                .ForeignKey("dbo.Customers", t => new { t.CustomerId, t.Name }, cascadeDelete: true)
                .Index(t => new { t.CustomerId, t.Name })
                .Index(t => t.AddressType)
                .Index(t => t.Country);
            
            CreateTable(
                "dbo.AddressTypes",
                c => new
                    {
                        AddressTypeId = c.String(nullable: false, maxLength: 1, unicode: false),
                        Description = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.AddressTypeId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryCode = c.String(nullable: false, maxLength: 2, unicode: false),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CountryCode);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.String(nullable: false, maxLength: 5, unicode: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => new { t.CustomerId, t.Name });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", new[] { "CustomerId", "Name" }, "dbo.Customers");
            DropForeignKey("dbo.Addresses", "Country", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "AddressType", "dbo.AddressTypes");
            DropIndex("dbo.Addresses", new[] { "Country" });
            DropIndex("dbo.Addresses", new[] { "AddressType" });
            DropIndex("dbo.Addresses", new[] { "CustomerId", "Name" });
            DropTable("dbo.Customers");
            DropTable("dbo.Countries");
            DropTable("dbo.AddressTypes");
            DropTable("dbo.Addresses");
        }
    }
}
