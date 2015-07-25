using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class VTController : Controller
    {
        // GET: VT
        public ActionResult Index()
        {
            int[] num = new int[]{1, 2, 3, 4, 5};
            return PartialView(num);
        }
    }
}