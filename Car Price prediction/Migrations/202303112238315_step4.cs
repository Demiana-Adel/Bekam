namespace Car_Price_prediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class step4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Used", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Used", c => c.Boolean(nullable: false));
        }
    }
}
