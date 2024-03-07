using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectorAutomat.Services
{
    internal enum State
    {
        None,
        Start,

        WholePart,
        OrderPart,
        FractionalPart,
        LetterE,
        Comma,
        OrderOperator,

        Success,
        Fail,
        Error,
    }
}
