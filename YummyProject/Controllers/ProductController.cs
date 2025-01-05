using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class ProductController : Controller
    {
        YummyContext context= new YummyContext();
        public ActionResult Index()
        {
            var products= context.Products.ToList();
            return View(products);
        }

        public ActionResult DeleteProduct(int id) 
        {
            var product= context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> category = (from x in context.Categories
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.kategoriler = category;

            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product model)
        {
            var product = context.Products.Find(model.ProductId);
            product.ProductName = model.ProductName;
            product.ImageUrl = model.ImageUrl;
            product.Price = model.Price;
            product.CategoryId = model.CategoryId;
            product.Ingredients = model.Ingredients;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> category = (from x in context.Categories
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.kategoriler = category;

            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product model)
        {
            context.Products.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}