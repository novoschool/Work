using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectorAutomat.Services
{
    internal enum CharClass
    {
        None,
        Alpha,
        Digit,
        LeftBracket,
        RightBracket,
        Comma,
        EndMarker,
        Other,
    }
}
