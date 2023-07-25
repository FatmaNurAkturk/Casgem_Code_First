using Casgem_Code_First.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Code_First.Controllers
{
    public class AboutController : Controller
    {
        TravelContext travelContext = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartalBreadcrumbs()
        {
            return PartialView();
        }
        public PartialViewResult PartialSliderScript()
        {
            return PartialView();

        }
        public PartialViewResult Gallery()
        {
            var values = travelContext.Galleries.ToList();
            return PartialView(values);

        }
        public PartialViewResult Detay()
        {
            return PartialView();
        }
        public PartialViewResult Team()
        {
            var values = travelContext.Guides.Include("SocialMedia").ToList();
            return PartialView(values);

        }
        public PartialViewResult Contact()
        {
            ViewBag.Adress = travelContext.Iletisims.Select(x => x.Address).FirstOrDefault();
            ViewBag.Telefon = travelContext.Iletisims.Select(x => x.Telefon).FirstOrDefault();
            ViewBag.Mail = travelContext.Iletisims.Select(x => x.Mail).FirstOrDefault();
            ViewBag.FaceURl = travelContext.Iletisims.Select(x => x.FaceURL).FirstOrDefault();
            ViewBag.InstagramURl = travelContext.Iletisims.Select(x => x.InsagramURL).FirstOrDefault();
            ViewBag.TwitterURL = travelContext.Iletisims.Select(x => x.TwitterURL).FirstOrDefault();
            ViewBag.MailURl = travelContext.Iletisims.Select(x => x.MailURL).FirstOrDefault();
            ViewBag.LinkedinURl = travelContext.Iletisims.Select(x => x.LinkedinURL).FirstOrDefault();

            var values = travelContext.Categories.ToList();

            return PartialView(values);
        }
        public PartialViewResult JS()
        {
            return PartialView();
        }
        public PartialViewResult Travel()
        {
            var values = travelContext.Travels.ToList();
            return PartialView(values);
        }
    }
}