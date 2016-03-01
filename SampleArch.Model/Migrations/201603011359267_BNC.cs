namespace SampleArch.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BNC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.About",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ServerName = c.String(),
                        VersionName = c.String(),
                        VersionReleaseDate = c.String(),
                        VersionCopyright = c.String(),
                        ServerTime = c.String(),
                        BncId = c.Int(nullable: false),
                        BncType = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Affiliate",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AffiliateId = c.Int(nullable: false),
                        AffiliateName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DecoderModel",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DbuId = c.Int(nullable: false),
                        HealthStatus = c.Int(nullable: false),
                        Info = c.String(),
                        Key = c.String(),
                        ModelNumber = c.String(),
                        TxnId = c.Long(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Address1 = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        DbuId = c.Int(nullable: false),
                        Name = c.String(),
                        State = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OperatorGroup",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OgId = c.Int(nullable: false),
                        OgName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Partition",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PtName = c.String(),
                        PtNumber = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 100),
                        State = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.RatingRegion",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RatingId = c.Int(nullable: false),
                        Name = c.String(),
                        RatingText = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OperatorGroupId = c.Int(nullable: false),
                        TierName = c.String(),
                        TierNumber = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SatTransponder",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SatelliteId = c.Int(nullable: false),
                        SatelliteName = c.String(),
                        TransponderId = c.Int(nullable: false),
                        TransponderName = c.String(),
                        Polarity = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tier",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OperatorGroupId = c.Int(nullable: false),
                        TierName = c.String(),
                        TierNumber = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "CountryId", "dbo.Countries");
            DropIndex("dbo.Person", new[] { "CountryId" });
            DropTable("dbo.Tier");
            DropTable("dbo.SatTransponder");
            DropTable("dbo.Region");
            DropTable("dbo.RatingRegion");
            DropTable("dbo.Person");
            DropTable("dbo.Partition");
            DropTable("dbo.OperatorGroup");
            DropTable("dbo.Location");
            DropTable("dbo.DecoderModel");
            DropTable("dbo.Countries");
            DropTable("dbo.Affiliate");
            DropTable("dbo.About");
        }
    }
}
