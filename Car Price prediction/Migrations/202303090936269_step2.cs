namespace Car_Price_prediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class step2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Used", c => c.Boolean(nullable: true, defaultValue:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Used");
        }
    }
}
