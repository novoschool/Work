using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntList
{
    internal class IncrementIntList : IntListBase
    {
        const int ArrayListIncrement = 8;

        protected override uint GetNewArraySize()
        {
            return _capacity + ArrayListIncrement;
        }
    }
}
