using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_Management_System.Controllers
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

        
        public ActionResult login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult registration()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult author()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult publisher()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult adminpage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult member()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult portfoliodetails()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult profile()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult signup()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}