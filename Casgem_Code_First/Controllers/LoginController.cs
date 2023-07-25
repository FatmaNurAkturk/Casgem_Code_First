using Casgem_Code_First.DAL.Context;
using Casgem_Code_First.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Casgem_Code_First.Controllers
{
    public class LoginController : Controller
    {
        TravelContext travelContext = new TravelContext();
        [HttpGet]

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {

            var user = travelContext.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                Session["usertravel"] = user.Username.ToString();
                return RedirectToAction("Index", "AdminAbout");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}