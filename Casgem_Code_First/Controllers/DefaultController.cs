using Casgem_Code_First.DAL.Context;
using Casgem_Code_First.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Code_First.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {

            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            ViewBag.Telefon = travelContext.Iletisims.Select(x => x.Telefon).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialSliderScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            var values = travelContext.Abouts.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialBooking()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialBooking(Booking p)
        {
            travelContext.Bookings.Add(p);
            travelContext.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = travelContext.Features.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDestinations()
        {
            var values = travelContext.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = travelContext.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBookingCover()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialMainScript()
        {
            return PartialView();
        }
    }
}