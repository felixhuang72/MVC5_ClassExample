using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestController : BaseController
    {
        // GET: Test
        public ActionResult Index(TestViewModel data)
        {
            /*Post 優先順序:
             * 1. ModelState
             * 2. Model
             * 3. ViewData
             * */

            //2. Model
            var dt = new TestViewModel() { Name = "felix", TitleName = "pr" };

            //List<SelectListItem> listItem = new List<SelectListItem>();
            //listItem.Add(new SelectListItem() { Text = "A", Value = "a" });
            //listItem.Add(new SelectListItem() { Text = "B", Value = "b" });
            //listItem.Add(new SelectListItem() { Text = "C", Value = "c" });
            //ViewData["List"] = new SelectList(listItem, "Value", "Text");

            ViewData["LevelOptions"] = new SelectList(db.Occupation.ToList(), "OccupationId", "OccupationName");
            ViewData["Level"] = 1;

            return View(dt);
        }
    }
}