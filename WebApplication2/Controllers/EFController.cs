using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EFController : Controller
    {
        public ActionResult Index()
        {
            var db = new FabricsEntities();

            var result = db.Product.Where(p => p.ProductId > 1500).ToList();

            return View(result);
        }

        public ActionResult RemoveClient()
        {
            var db = new FabricsEntities();
            var data = db.Client.Take(5);

            foreach (var client in data)
            {
                foreach (var order in client.Order)
                {
                    db.OrderLine.RemoveRange(order.OrderLine);
                }
                db.Order.RemoveRange(client.Order);
            }
            db.Client.RemoveRange(data);
            db.SaveChanges();
            return View(data);
        }

        

        public ActionResult Update5()
        {
            var db = new FabricsEntities();
            var data = db.Client.Take(5);
            foreach (var c in data)
            {
                c.City = "Taipei";
            }
            db.SaveChanges();
            return View(data);
        }



        // GET: EF
        public int AddProduct()
        {   
            using (var db = new FabricsEntities())
            {
                Product product = new Product();

                product = new Product()
                {
                    ProductName = "Tee white",
                    Active = true,
                    Stock = 10,
                    Price = 299
                };
                db.Product.Add(product);
                db.SaveChanges();

                return product.ProductId;
            }
        }
    }
}