using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViaBikeRack.Models
{
    public class BikeRackModel
    {
        [Required]
        public int Id { get; set; }

        #region Database admin can add information
        //The person adding information to the database can add routes, busses, and bus racks 
        [Required]
        [Display(Name = "Bus Route")]
        public int Route_Number { get; set; }

        [Required]
        [Display(Name = "Bus Number")]
        public int Bus_Number { get; set; }

        [Display(Name = "Bike Rack One")]
        public bool Bike_Rack_1 { get; set; }

        [Display(Name = "Bike Rack Two")]
        public bool Bike_Rack_2 { get; set; }

        [Display(Name = "Bike Rack Three")]
        public bool Bike_Rack_3 { get; set; }
        #endregion

        #region Bus driver can adjust rack usage in this section

        [Display(Name = "Bike Rack 1")]
        public bool IsActive_Bike_Rack_1 { get; set; }

        [Display(Name = "Bike Rack 2")]
        public bool IsActive_Bike_Rack_2 { get; set; }

        [Display(Name = "Bike Rack 3")]
        public bool IsActive_Bike_Rack_3 { get; set; }
        #endregion
    }
}