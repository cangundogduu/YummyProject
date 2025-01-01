using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class AboutController : Controller
    {
        YummyContext context = new YummyContext();
        // GET: About
        public ActionResult Index()
        {
            var values= context.Abouts.ToList();
            return View(values);
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About model)
        {
            var value= context.Abouts.FirstOrDefault(x=>x.AboutId==model.AboutId);
            value.ImageUrl = model.ImageUrl;
            value.Item1 = model.Item1;
            value.Item2 = model.Item2;
            value.Item3 = model.Item3;
            value.Description = model.Description;
            value.VideoUrl = model.VideoUrl;
            value.PhoneNumber = model.PhoneNumber;
            value.ImageUrl2 = model.ImageUrl2;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About model) 
        {
            context.Abouts.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}