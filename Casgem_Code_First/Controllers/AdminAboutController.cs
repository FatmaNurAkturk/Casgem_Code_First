using Casgem_Code_First.DAL.Context;
using Casgem_Code_First.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Code_First.Controllers
{
    //[Authorize]
    public class AdminAboutController : Controller
    {
        TravelContext travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = travelContext.Abouts.ToList();
            return View(values);
        }


        public ActionResult DeleteAbout(int id)
        {
            var values = travelContext.Abouts.Find(id);
            travelContext.Abouts.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AboutUpdate(int id)
        {
            var values = travelContext.Abouts.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult AboutUpdate(About p)
        {
            var values = travelContext.Abouts.Find(p.AboutID);
            values.AboutDes = p.AboutDes;
            values.AboutTitle = p.AboutTitle;
            values.AboutResim = p.AboutResim;

            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}