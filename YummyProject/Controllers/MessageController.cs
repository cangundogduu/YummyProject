﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{
    public class MessageController : Controller
    {
        YummyContext context= new YummyContext();
        public ActionResult Index()
        {
            var values= context.Messages.ToList();
            return View(values);
        }

        public ActionResult IsReadMessage(int id)
        {
            var value= context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}