namespace Car_Price_prediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "img");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "img", c => c.String());
        }
    }
}
