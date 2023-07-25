using Casgem_Code_First.DAL.Context;
using Casgem_Code_First.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Code_First.Controllers
{
    public class SocialMediaController : Controller
    {
        TravelContext _travelContext = new TravelContext();
        // GET: SocailMedia
        public ActionResult Index()
        {
            var values = _travelContext.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            var values = (from guide in _travelContext.Guides.ToList()
                          select new SelectListItem
                          {
                              Value = guide.GuideID.ToString(),
                              Text = guide.GuideName
                          }).ToList();
            ViewBag.v = values;

            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            _travelContext.SocialMedias.Add(socialMedia);
            _travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}