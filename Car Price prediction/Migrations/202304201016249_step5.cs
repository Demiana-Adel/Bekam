namespace Car_Price_prediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class step5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShowroomReviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        data = c.DateTime(nullable: false),
                        Message = c.String(),
                        phoneNumber = c.String(),
                        UserID = c.String(maxLength: 128),
                        ShowroomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ShowroomsForTraders", t => t.ShowroomID, cascadeDelete: true)
                .ForeignKey("dbo.IdentityUsers", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.ShowroomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShowroomReviews", "UserID", "dbo.IdentityUsers");
            DropForeignKey("dbo.ShowroomReviews", "ShowroomID", "dbo.ShowroomsForTraders");
            DropIndex("dbo.ShowroomReviews", new[] { "ShowroomID" });
            DropIndex("dbo.ShowroomReviews", new[] { "UserID" });
            DropTable("dbo.ShowroomReviews");
        }
    }
}
