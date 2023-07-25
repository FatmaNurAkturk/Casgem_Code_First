using Casgem_Code_First.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Code_First.Controllers
{
    public class AdminBookingController : Controller
    {
        TravelContext travelContext = new TravelContext();
        // GET: Admin_Guide
        public ActionResult Index()
        {
            var values = travelContext.Bookings.ToList();
            return View(values);
        }

        public ActionResult DeleteBooking(int id)
        {
            var values = travelContext.Bookings.Find(id);
            travelContext.Bookings.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}