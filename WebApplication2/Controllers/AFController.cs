using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.ActionFilters;

namespace WebApplication2.Controllers
{
    
    public class AFController : Controller
    {
        // GET: AF

        [MyFilter]
        [OutputCache(Duration=10)]
        public ActionResult Index()
        {
            System.IO.File.AppendAllText(@"C:\Users\Admin\Desktop\filter.log", "#2\n");

            //throw new Exception("Error");

            return View();

        }
    }
}