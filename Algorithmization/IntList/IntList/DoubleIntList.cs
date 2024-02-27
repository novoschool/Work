using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntList
{
    internal class DoubleIntList : IntListBase
    {
        protected override uint GetNewArraySize()
        {
            return _capacity * 2;
        }
    }
}
