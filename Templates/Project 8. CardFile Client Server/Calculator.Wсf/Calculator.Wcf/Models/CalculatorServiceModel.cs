using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Wcf.Models
{
    [DataContract]
    public class CalculatorServiceModel
    {
        [DataMember]
        public double XRegister { get; set; }

        [DataMember]
        public double YRegister { get; set; }

        [DataMember]
        public string Operator { get; set; }

        [DataMember]
        public bool DigitInputMode { get; set; }
    }
}
