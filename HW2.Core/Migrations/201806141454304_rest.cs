namespace TP.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PathElements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodId = c.Int(nullable: false),
                        Time_TimeOfEat = c.String(),
                        Price = c.Int(nullable: false),
                        RestaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RestaurantName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PathElements", "RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.PathElements", new[] { "RestaurantId" });
            DropTable("dbo.Users");
            DropTable("dbo.Restaurants");
            DropTable("dbo.PathElements");
            DropTable("dbo.Food");
        }
    }
}
