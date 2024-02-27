using Calculator.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business.Services
{
    public class CalculatorService
    {
        public CalculatorModel Model { get; } = new CalculatorModel();

        public void InputDigit(int digit)
        {
            if (Model.ClearRegister)
            {
                Model.XRegister = digit;
            }
            else
            {
                Model.XRegister = Model.XRegister * 10 + digit;
            }

            Model.ClearRegister = false;
        }

        public void Clear()
        {
            Model.XRegister = 0;
            Model.ClearRegister = true;
        }

        public void MoveXToY()
        {
            Model.YRegister = Model.XRegister;
        }

        public void ApplyOperator(string opCode)
        {
            switch (Model.LastOpCode)
            {
                case "+":
                    Model.XRegister = Model.XRegister + Model.YRegister;
                    break;
                case "-":
                    Model.XRegister = Model.YRegister - Model.XRegister;
                    break;
                case "*":
                    Model.XRegister = Model.XRegister * Model.YRegister;
                    break;
                case "/":
                    if (Model.YRegister == 0)
                    {
                        Model.XRegister = double.NaN;
                        break;
                    }

                    Model.XRegister = Model.YRegister / Model.XRegister;
                    break;
            }

            MoveXToY();
            Model.LastOpCode = opCode;
            Model.ClearRegister = true;
        }
    }
}
