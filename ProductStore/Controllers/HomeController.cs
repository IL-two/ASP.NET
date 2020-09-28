using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        ProductCt db = new ProductCt();
        public ActionResult Index(string category, string searchString)
        {
            IQueryable<string> categoryQuery = from m in db.Products
                                               orderby m.Category
                                               select m.Category;
            var product = from p in db.Products
                          select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                product = product.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(category))
            {
                product = product.Where(x => x.Category == category);
            }
            var categoryVM = new CategoryProduct
            {
                CategoryProducts = new SelectList(categoryQuery.Distinct().ToList()),
                Products = product.ToList()                
            };
            return View(categoryVM);
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
        [HttpGet]
        public ActionResult AddProduct()
        {
            Product product = new Product();
            product.Date = DateTime.Now;
            return View(product);
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product product = new Product();
            foreach(Product p in db.Products)
            {
                if (p.Id == id)
                {
                    product.Category = p.Category;
                    product.Name = p.Name;
                    product.Price = p.Price;
                    product.Date = p.Date;
                }
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(Product product)
        {
            try
            {
                foreach (Product p in db.Products)
                {
                    if (product.Id == p.Id)
                    {
                        db.Products.Remove(p);                        
                    }                    
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(product);
            }
        }
    }
}