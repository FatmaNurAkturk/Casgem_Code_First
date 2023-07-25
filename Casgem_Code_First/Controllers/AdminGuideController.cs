using Casgem_Code_First.DAL.Context;
using Casgem_Code_First.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Code_First.Controllers
{
    public class AdminGuideController : Controller
    {
        TravelContext travelContext = new TravelContext();
        // GET: Admin_Guide
        public ActionResult Index()
        {
            var values = travelContext.Guides.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGuide(Guide p)
        {
            travelContext.Guides.Add(p);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteGuide(int id)
        {
            var values = travelContext.Guides.Find(id);
            travelContext.Guides.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GuideUpdate(int id)
        {
            var values = travelContext.Guides.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult GuideUpdate(Guide p)
        {
            var values = travelContext.Guides.Find(p.GuideID);
            values.GuideName = p.GuideName;
            values.GuideTitle = p.GuideTitle;
            values.GuideImageUrl = p.GuideImageUrl;

            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}