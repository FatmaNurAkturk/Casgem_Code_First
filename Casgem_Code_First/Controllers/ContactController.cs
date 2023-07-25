using Casgem_Code_First.DAL.Context;
using Casgem_Code_First.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Code_First.Controllers
{
    public class ContactController : Controller
    {
        TravelContext travelContext = new TravelContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact p)
        {
            travelContext.Contacts.Add(p);
            p.MessageDate = DateTime.Now;
            travelContext.SaveChanges();

            return RedirectToAction("Index", "Contact");

        }
        public PartialViewResult Dess()
        {
            return PartialView();
        }
        public PartialViewResult Map()
        {
            var values = travelContext.Iletisims.ToList();
            return PartialView(values);

        }
    }
}