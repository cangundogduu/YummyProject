﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class ContactController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.ContactInfoes.ToList();
            return View(values);
        }

        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(ContactInfo model)
        {
            var values = context.ContactInfoes.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(int id)
        {
            var values = context.ContactInfoes.Find(id);
            context.ContactInfoes.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateContact(int id)
        {
            var values = context.ContactInfoes.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateContact(ContactInfo model)
        {
            var values = context.ContactInfoes.Find(model.ContantInfoId);
            values.Address = model.Address;
            values.Email = model.Email;
            values.PhoneNumber = model.PhoneNumber;
            values.MapUrl = model.MapUrl;
            values.OpenHours = model.OpenHours;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}