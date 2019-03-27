using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WTGproject;

//using System.data.Entity to use db entity


namespace WTGproject.Controllers
{
    public class HomeController : Controller
    {


        //db endtity object
        private WTGEntities db = new WTGEntities();

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
            var exercises = db.Exercise;
            return View(exercises.ToList());
        }

        public ActionResult Profilepage()
        {
            ViewBag.Message = "Your Profile page.";

            var exercises = db.Exercise;
            return View(exercises.ToList());
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