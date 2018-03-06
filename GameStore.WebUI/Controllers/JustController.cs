using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GameStore.WebUI.Models;

namespace GameStore.WebUI.Controllers
{
    public class JustController : Controller
    {
        private static int cycles;
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

            ViewBag.Cycles = cycles;
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
        [HttpGet]
        public string Square(int a, int h)
        {
            double s = a * h / 2.0;
            return "<h2>Площадь треугольника с основанием " + a +
                   " и высотой " + h + " равна " + s + "</h2>";
        }
        public string ContextData()
        {
            HttpContext.Response.Write("<h1>Hello World</h1>");

            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                   "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";
        }

        public ActionResult StartMonitor()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    cycles++;
                    Task.Delay(1000).Wait();
                }
            });
            ViewBag.Mess = "Started";
            return View();
        }
    }
}