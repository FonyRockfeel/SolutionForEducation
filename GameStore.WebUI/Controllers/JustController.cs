using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.WebUI.Models;

namespace GameStore.WebUI.Controllers
{
    public class JustController : Controller
    {
        // GET: Just
        public ActionResult Index()
        {
            var t = new List<string>();
            t.Add("3543");
            t.Add("sdg5wgw");
            t.Add("sdg343wgw");
            t.Add("sdgwgw");
            t.Add("sdgwerygw");
            t.Add("sdgwerygw");
            t.Add("sdgwehwewgw");
            t.Add("sdgwg3646346346w");
            return View(t);
        }
        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
                return View("Thanks", guest);
            return View();
        }
    }
}