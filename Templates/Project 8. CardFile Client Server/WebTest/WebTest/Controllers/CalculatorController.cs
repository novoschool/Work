using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InputDigit(int digit)
        {
            return View("Index");
        }

        public ActionResult InputOperator(string opCode)
        {
            return View("Index");
        }

        public ActionResult Clear()
        {
            return View("Index");
        }
    }
}