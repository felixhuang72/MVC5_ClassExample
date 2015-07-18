using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
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


        public ActionResult ARtest()
        {
            return View();
        }

        public ActionResult ARtestPartial()
        {
            return PartialView("ARtest");
        }

        public ActionResult FileTest()
        {
            return File(Server.MapPath("~/Content/_037710.jpg"), "image/jpeg", "037710-TEST.jpg");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}