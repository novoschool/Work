using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class DialogController : Controller
    {
        // GET: Dialog
        public ActionResult Index()
        {
            ViewBag.GreetingMessage = "Представьтесь, пожалуйста: ";
            ViewBag.AgeMessage = "Ваш возраст, пожалуйста: ";
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserNameModel model)
        {
            ValidateModel(model);
            return View("Reply", model);
        }
    }
}