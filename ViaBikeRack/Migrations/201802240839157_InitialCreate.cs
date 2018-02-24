namespace ViaBikeRack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BikeRackModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Route_Number = c.Int(nullable: false),
                        Bus_Number = c.Int(nullable: false),
                        Bike_Rack_1 = c.Boolean(nullable: false),
                        Bike_Rack_2 = c.Boolean(nullable: false),
                        Bike_Rack_3 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BikeRackModels");
        }
    }
}
