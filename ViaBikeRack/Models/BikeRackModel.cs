using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViaBikeRack.Models
{
    public class BikeRackModel
    {
        public int Id { get; set; }

        public int Route_Number { get; set; }

        public int Bus_Number { get; set; }

        public bool Bike_Rack_1 { get; set; }

        public bool Bike_Rack_2 { get; set; }

        public bool Bike_Rack_3 { get; set; }
    }
}