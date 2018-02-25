using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViaBikeRack.Data;
using ViaBikeRack.Models;

namespace ViaBikeRack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BikeRackModel bikeStatus = new BikeRackModel();
            //Connecting to Database
            BikeRackCheckerContext db = new BikeRackCheckerContext();

            ViewBag.BusRoute = new SelectList(db.BikeRackModels, "Id", "Route_Number");

            ViewBag.BusNumber = new SelectList(db.BikeRackModels, "Id", "Bus_Number");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditBikeRackState(int Id)
        {
            BikeRackModel bikeRack = new BikeRackModel();

            return View("Index");
        }

        [HttpPost]
        public ActionResult EditBikeRackState([Bind(Include = "Id,IsActive_Bike_Rack_1,IsActive_Bike_Rack_2,IsActive_Bike_Rack_3")] BikeRackModel bikeRackModel)
        {
            BikeRackCheckerContext db = new BikeRackCheckerContext();

            BikeRackModel bikeRack = new BikeRackModel();

            if (ModelState.IsValid)
            {
                var old_model = db.BikeRackModels.SingleOrDefault(x => x.Id == bikeRackModel.Id);
                old_model = bikeRackModel;
                //if (bikeRack.IsActive_Bike_Rack_1 == false)
                //{
                //    bikeRack.IsActive_Bike_Rack_1 = true;
                //} else
                //{
                //    bikeRack.IsActive_Bike_Rack_1 = false;
                //}

                db.Entry(old_model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bikeRackModel);
        }

    }
}