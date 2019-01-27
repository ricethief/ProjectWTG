using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WTGwebb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Training()
        {
            ViewBag.Message = "Your Training page.";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your Create Training page.";

            return View();
        }

        public ActionResult Profilepage()
        {
            ViewBag.Message = "Your Profile page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your Create Training page.";

            return View();
        }

        public ActionResult Signup()
        {
            ViewBag.Message = "Your Create Signup page.";

            return View();
        }
    }
}