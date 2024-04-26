namespace Car_Price_prediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class step6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.user_cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InsertionDate = c.DateTime(nullable: false),
                        UserID = c.String(maxLength: 128),
                        CarID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cars", t => t.CarID, cascadeDelete: true)
                .ForeignKey("dbo.IdentityUsers", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.CarID);

            AddColumn("dbo.Cars", "Active", c => c.Boolean(nullable: false, defaultValue: true));
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.user_cars", "UserID", "dbo.IdentityUsers");
            DropForeignKey("dbo.user_cars", "CarID", "dbo.Cars");
            DropIndex("dbo.user_cars", new[] { "CarID" });
            DropIndex("dbo.user_cars", new[] { "UserID" });
            DropColumn("dbo.Cars", "Active");
            DropTable("dbo.user_cars");
        }
    }
}
