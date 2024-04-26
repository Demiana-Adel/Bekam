namespace Car_Price_prediction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class step3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Governorate = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Neighborhood = c.String(),
                        ShoowroomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ShowroomsForTraders", t => t.ShoowroomId, cascadeDelete: true)
                .Index(t => t.ShoowroomId);
            
            CreateTable(
                "dbo.ShowroomsForTraders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TraderName = c.String(),
                        ShowroomName = c.String(),
                        PhoneNumber0 = c.String(),
                        PhoneNumber1 = c.String(),
                        Email = c.String(),
                        Discription = c.String(),
                        Logo = c.String(),
                        CoverImage = c.String(),
                        UserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IdentityUsers", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "ShoowroomId", "dbo.ShowroomsForTraders");
            DropForeignKey("dbo.ShowroomsForTraders", "UserID", "dbo.IdentityUsers");
            DropIndex("dbo.ShowroomsForTraders", new[] { "UserID" });
            DropIndex("dbo.Locations", new[] { "ShoowroomId" });
            DropTable("dbo.ShowroomsForTraders");
            DropTable("dbo.Locations");
        }
    }
}
