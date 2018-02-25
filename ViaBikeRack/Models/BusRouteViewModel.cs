using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace ViaBikeRack.VIewModel
{
    public class BusRouteViewModel
    {
        [Display(Name = "Routes")]
        public string SelectedBusRoute { get; set; }
        public IEnumerable<SelectListItem> Routes { get; set; }
    }
}