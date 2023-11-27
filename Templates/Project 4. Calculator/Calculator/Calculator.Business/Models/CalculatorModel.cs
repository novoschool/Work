using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business.Models
{
    public class CalculatorModel
    {
        public double XRegister { get; internal set; }

        public double YRegister { get; internal set; }

        public string LastOpCode { get; internal set; }

        public bool ClearRegister { get; internal set; }
    }
}
