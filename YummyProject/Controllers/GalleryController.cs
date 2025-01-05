using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class GalleryController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values= context.PhotoGalleries.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddGallery()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddGallery(PhotoGallery model)
        {
            context.PhotoGalleries.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateGallery(int id)
        {
            var value= context.PhotoGalleries.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateGallery(PhotoGallery model)
        {
            var value = context.PhotoGalleries.Find(model.PhotoGalleryId);
            value.ImageUrl = model.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
          
        }

        public ActionResult DeleteGallery(int id) 
        {
            var value = context.PhotoGalleries.Find(id);
            context.PhotoGalleries.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        
        }


    }
}