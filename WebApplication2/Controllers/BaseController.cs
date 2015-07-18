using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public abstract class BaseController : Controller
    {

        protected FabricsEntities db = new FabricsEntities();


        public string myMethod()
        {
            return "test";
        }
     
        protected override void HandleUnknownAction(string actionName)
        {
            if (this.ControllerContext.HttpContext.Request.HttpMethod.ToUpper() == "GET")
            {
                this.Redirect("/").ExecuteResult(this.ControllerContext);
            }
            else
            {
                base.HandleUnknownAction(actionName);
            }
        }

    }
}