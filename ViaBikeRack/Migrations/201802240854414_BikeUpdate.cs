namespace ViaBikeRack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BikeUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BikeRackModels", "IsActive_Bike_Rack_1", c => c.Boolean(nullable: false));
            AddColumn("dbo.BikeRackModels", "IsActive_Bike_Rack_2", c => c.Boolean(nullable: false));
            AddColumn("dbo.BikeRackModels", "IsActive_Bike_Rack_3", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BikeRackModels", "IsActive_Bike_Rack_3");
            DropColumn("dbo.BikeRackModels", "IsActive_Bike_Rack_2");
            DropColumn("dbo.BikeRackModels", "IsActive_Bike_Rack_1");
        }
    }
}
