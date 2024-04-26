namespace Car_Price_prediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNEWimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarImages", "RightSideimage", c => c.String());
            AddColumn("dbo.CarImages", "LeftSideimage", c => c.String());
            DropColumn("dbo.CarImages", "Sideimage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CarImages", "Sideimage", c => c.String());
            DropColumn("dbo.CarImages", "LeftSideimage");
            DropColumn("dbo.CarImages", "RightSideimage");
        }
    }
}
