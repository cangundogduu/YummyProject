using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    public class DashboardController : Controller
    {
        YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            //kategorisi "Çorbalar" olan ürünlerin toplamını göster
            ViewBag.soupCount= context.Products.Count(x=>x.Category.CategoryName=="Çorbalar");

            //en yüksek değerdeki ürünü göster
            ViewBag.mostExpensive = context.Products.OrderByDescending(x => x.Price).Select(x => x.ProductName).FirstOrDefault();

            //ürünlerin ortalama fiyatı           
            ViewBag.avgPrice = context.Products.Average(x => x.Price);

            //En ucuz ürünü getir.
            ViewBag.cheapestPrice=context.Products.OrderBy(x=>x.Price).Select(x=>x.ProductName).FirstOrDefault();
            
            return View();
        }
    }
}