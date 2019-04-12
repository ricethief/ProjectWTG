using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WTGproject.DatabaseEntity;
using WTGproject.Controllers;
using Microsoft.AspNet.Identity;


//using System.data.Entity to use db entity


namespace WTGproject.Controllers
{
    public class HomeController : Controller
    {


        //db endtity object
        private DBEntities db = new DBEntities();



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

        public ActionResult Training(string[] chkdate)
        {
            //getting loged in user information
            User.Identity.GetUserId();
            //getting trainingDetail data from DB table
            var trainingDetail = db.TrainingDetails;

            if (!(User.Identity.GetUserId() == null))
            {
                //getting values from create training page
                string _id = User.Identity.GetUserId();
                int _week = int.Parse(Request["slider"]);
                string _frequency = chkdate.Count().ToString();
                decimal _intensity = decimal.Parse(Request["slider2"]);
                //new training obj
                Training training = new Training();
                training.fk_AspNetUser_ID = _id;
                training.week = _week;
                training.frequency = _frequency;
                training.Intensity = _intensity;
                //check the fruequency trough number of checked checkbox
                //previouse code
                //int _sum = 0;
                //for (int i = 0; i < chkdate.Count(); i++)
                //{
                //    _sum++;
                //    _frequency = _sum.ToString();
                //}


                if (chkdate.Contains("Monday"))
                {

                    ViewBag.Message = "Monday it is";
                }

                else
                {
                    ViewBag.Message = "Not Monday it is";
                }

                
                ViewBag.id = "id is "+_id;
                ViewBag.week = "week is "+_week;
                ViewBag.frequency = "frequency is " + _frequency;
                ViewBag.intensity = "intensity is "+_intensity;

                return View(trainingDetail.ToList());
            }
            else
            {
                ViewBag.Message = "You are not loged in";
                return View();
            }


        }

        public ActionResult Create()
        {
            User.Identity.GetUserId();
            if (!(User.Identity.GetUserId() == null))
            {
                ViewBag.Message = User.Identity.GetUserId();
            }
            else
            {
                ViewBag.Message = "You are not loged in";
            }
            var exercises = db.Exercises;
            return View(exercises.ToList());
        }



        public ActionResult Profilepage()
        {
            ViewBag.Message = "Your Profile page.";

            var exercises = db.Exercises;
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