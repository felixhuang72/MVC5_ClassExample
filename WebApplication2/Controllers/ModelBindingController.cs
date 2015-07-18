using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: ModelBinding
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SampleVM data)
        {
            if(ModelState.IsValid)
            {
                TempData["msg"] = "新增" + data.Name + "成功!";
                return RedirectToAction("IndexResult");
            }   
                return View();
        }

        
        public ActionResult IndexResult()
        {
            return View();
        }
        

        
        
    }
}