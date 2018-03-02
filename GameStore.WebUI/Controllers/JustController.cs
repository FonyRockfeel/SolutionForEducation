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
            return View();
        }
        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            return View("Thanks", guest);
        }
    }
}