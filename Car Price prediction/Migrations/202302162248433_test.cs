namespace Car_Price_prediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "img", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "img");
        }
    }
}
