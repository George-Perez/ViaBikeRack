using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ViaBikeRack.Models;

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