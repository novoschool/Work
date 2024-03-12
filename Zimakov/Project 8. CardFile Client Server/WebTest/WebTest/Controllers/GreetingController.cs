using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VeryGood()
        {
            return View("Reply");
        }
    }
}