using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    public class BookingController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.Bookings.ToList();
            return View(values);
        }

        public ActionResult ConfirmBooking(int id)
        {
            var value = context.Bookings.FirstOrDefault(x => x.BookingId == id);
            value.IsApproved = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeclineBooking(int id)
        {
            var value = context.Bookings.FirstOrDefault(x => x.BookingId == id);
            value.IsApproved = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}