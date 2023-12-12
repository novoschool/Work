using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2.Business.Models
{
    public class CalculatorModel
    {
        public double XRegister { get; set; }

        public double YRegister { get; set; }

        public string Operator { get; set; }

        public bool DigitInputMode { get; set; }
    }
}
