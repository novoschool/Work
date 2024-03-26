using Calculator.Wcf.Models;
using Calculator2.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Wcf.Services
{
    public partial class CalculatorService : ServiceBase, ICalculatorService
    {
        private readonly Calculator2.Business.Services.CalculatorService _service = new Calculator2.Business.Services.CalculatorService();

        public CalculatorServiceModel AddDigit(CalculatorServiceModel model, int digit)
        {
            var localModel = ConvertModel(model);
            _service.AddDigit(localModel, digit);
            return ConvertModel(localModel);
        }

        public CalculatorServiceModel Clear(CalculatorServiceModel model)
        {
            var localModel = ConvertModel(model);
            _service.Clear(localModel);
            return ConvertModel(localModel);
        }

        public CalculatorServiceModel InsertOperator(CalculatorServiceModel model, string opCode)
        {
            var localModel = ConvertModel(model);
            _service.InsertOperator(localModel, opCode);
            return ConvertModel(localModel);
        }

        private CalculatorModel ConvertModel(CalculatorServiceModel model)
        {
            return new CalculatorModel
            {
                XRegister = model.XRegister,
                YRegister = model.YRegister,
                DigitInputMode = model.DigitInputMode,
                Operator = model.Operator,
            };
        }

        private CalculatorServiceModel ConvertModel(CalculatorModel model)
        {
            return new CalculatorServiceModel
            {
                XRegister = model.XRegister,
                YRegister = model.YRegister,
                DigitInputMode = model.DigitInputMode,
                Operator = model.Operator,
            };
        }
    }
}
