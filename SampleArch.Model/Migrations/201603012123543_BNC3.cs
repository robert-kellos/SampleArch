namespace SampleArch.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BNC3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String(maxLength: 100));
        }
    }
}
