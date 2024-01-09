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
            if (model.DigitInputMode)
            {
                model.XRegister = model.XRegister * 10 + digit;
            }
            else
            {
                model.XRegister = digit;
            }

            model.DigitInputMode = true;
        }

        public void Clear(CalculatorModel model)
        {
            model.XRegister = 0;
            model.YRegister = 0;
            model.Operator = string.Empty;
            model.DigitInputMode = false;
        }

        public void MoveXToY(CalculatorModel model)
        {
            model.YRegister = model.XRegister;
        }

        public void Execute(CalculatorModel model, string opCode)
        {
            switch (opCode)
            {
                case "+":
                    model.XRegister = model.XRegister + model.YRegister;
                    break;

                case "-":
                    model.XRegister = model.YRegister - model.XRegister;
                    break;

                case "*":
                    model.XRegister = model.XRegister * model.YRegister;
                    break;

                case "/":
                    model.XRegister = model.YRegister / model.XRegister;
                    break;
            }
        }

        public void InsertOperator(CalculatorModel model, string opCode)
        {
            ExecuteOperator(model);

            MoveXToY(model);
            model.Operator = opCode;
            model.DigitInputMode = false;
        }

        public void ExecuteOperator(CalculatorModel model)
        {
            Execute(model, model.Operator);
        }
    }
}
