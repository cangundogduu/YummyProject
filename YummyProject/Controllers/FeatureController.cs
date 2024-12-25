using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    
    public class FeatureController : Controller
    {
        // GET: Feature
        YummyContext context=new YummyContext();
      
        
        public ActionResult Index()
        {
            var values= context.Features.ToList();

            return View(values);
        }



        public ActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFeature(Feature feature)
        {

            if (!ModelState.IsValid) 
            {
                return View(feature);
            }

            context.Features.Add(feature);
            int result=context.SaveChanges();
            if (result == 0) 
            {
                ViewBag.Error = "Değerler kaydedilirken bir hata ile karşılaşıldı.";
                return View(feature);
            }
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);
            context.Features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}