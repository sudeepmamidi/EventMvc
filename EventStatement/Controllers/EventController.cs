using EventStatement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventStatement.Controllers
{
    public class EventController : Controller
    {
        EventContext db = new EventContext();
        // GET: Event
        public ActionResult Index()
        {
            return View(db.events.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Event eve)
        {
            if (ModelState.IsValid)
            {
                db.events.Add(eve);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error occured");
            }
            return View(eve);
        }
    }
}