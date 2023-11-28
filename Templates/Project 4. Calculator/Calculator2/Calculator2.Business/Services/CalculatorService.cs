using Calculator2.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2.Business.Services
{
    public class CalculatorService
    {
        public void AddDigit(CalculatorModel model, int digit)
        {
            model.XRegister = model.XRegister * 10 + digit;
        }

        public void Clear(CalculatorModel model)
        {
            model.XRegister = 0;
        }
    }
}
