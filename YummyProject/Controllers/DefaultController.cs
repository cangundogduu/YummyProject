using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default

        YummyContext context=new YummyContext();
        public ActionResult Index()
        {
            ViewBag.eventCount=context.Events.Count();
            ViewBag.chefCount = context.Chefs.Count();
            ViewBag.productCount=context.Products.Count();
            ViewBag.avgPrice = context.Products.Average(x=>x.Price);
            return View();
        }

        public PartialViewResult DefaultFeature() 
        {
            var values=context.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultAbout()
        {
            var values= context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultProduct()
        {
            var values=context.Categories.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultService()
        {
            var value = context.Services.FirstOrDefault();
            return PartialView(value);
        }

        public PartialViewResult DefaultServiceDetail()
        {
            var values= context.ServiceDetails.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultTestimonial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultEvent()
        {
            var values= context.Events.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultChef()
        {
            var values= context.Chefs.ToList();
            return PartialView(values);
        }

    }
}