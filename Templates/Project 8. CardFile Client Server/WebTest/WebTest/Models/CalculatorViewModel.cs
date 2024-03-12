using Calculator2.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class CalculatorViewModel
    {
        public double XRegister { get; set; }

        public double YRegister { get; set; }

        public string Operator { get; set; }

        public bool DigitInputMode { get; set; }

        public static CalculatorViewModel FromBusinessModel(CalculatorModel businessModel)
        {
            if (businessModel == null)
            {
                return null;
            }

            return new CalculatorViewModel
            {
                XRegister = businessModel.XRegister,
                YRegister = businessModel.YRegister,
                Operator = businessModel.Operator,
                DigitInputMode = businessModel.DigitInputMode,
            };
        }
    }
}