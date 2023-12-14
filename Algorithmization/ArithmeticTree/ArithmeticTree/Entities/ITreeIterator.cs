using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree.Entities
{
    internal interface ITreeIterator
    {
        TreeNode? Current { get; }

        void MoveNext();

        void Reset();
    }
}
