using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViaBikeRack.Data
{
    public class BikeRackCheckerContext : DbContext
    {
        public BikeRackCheckerContext() : base("DefaultConnection")
        {
        }

        public DbSet<BikeRackModel> BikeRackModels { get; set; }

    }
}