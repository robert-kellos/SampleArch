namespace SampleArch.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BNC1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Person", "CountryId", "dbo.Countries");
            DropIndex("dbo.Person", new[] { "CountryId" });
            DropPrimaryKey("dbo.Countries");
            AlterColumn("dbo.Countries", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Person", "CountryId", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Countries", "Id");
            CreateIndex("dbo.Person", "CountryId");
            AddForeignKey("dbo.Person", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "CountryId", "dbo.Countries");
            DropIndex("dbo.Person", new[] { "CountryId" });
            DropPrimaryKey("dbo.Countries");
            AlterColumn("dbo.Person", "CountryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Countries", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Countries", "Id");
            CreateIndex("dbo.Person", "CountryId");
            AddForeignKey("dbo.Person", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
    }
}
