using Calculator2.Business.Models;
using Calculator2.Business.Services;
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
        private readonly static CalculatorService _service = new CalculatorService();

        private CalculatorModel GetModel()
        {
            if (Session["CalculatorModel"] == null)
            {
                Session["CalculatorModel"] = new CalculatorModel();
            }

            return (CalculatorModel)Session["CalculatorModel"];
        }

        // GET: Calculator
        public ActionResult Index()
        {
            var model = GetModel();
            return View(CalculatorViewModel.FromBusinessModel(model));
        }

        public ActionResult InputDigit(int digit)
        {
            var model = GetModel();
            _service.AddDigit(model, digit);
            return View("Index", CalculatorViewModel.FromBusinessModel(model));
        }

        public ActionResult InputOperator(string opCode)
        {
            var model = GetModel();
            _service.InsertOperator(model, opCode);
            return View("Index", CalculatorViewModel.FromBusinessModel(model));
        }

        public ActionResult Clear()
        {
            var model = GetModel();
            _service.Clear(model);
            return View("Index", CalculatorViewModel.FromBusinessModel(model));
        }
    }
}