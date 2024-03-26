using Calculator.Wcf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Wcf.Services
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        CalculatorServiceModel AddDigit(CalculatorServiceModel model, int digit);

        [OperationContract]
        CalculatorServiceModel Clear(CalculatorServiceModel model);

        [OperationContract]
        CalculatorServiceModel InsertOperator(CalculatorServiceModel model, string opCode);
    }
}
