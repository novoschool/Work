using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree.Entities
{
    internal class Tree
    {
        public TreeNode? Root { get; set; }

        public void ProcessLeftToRight(StringBuilder sb)
        {
            Root?.ProcessLeftToRight(sb);
        }

        public void ProcessTopDown(StringBuilder sb)
        {
            Root?.ProcessTopDown(sb);
        }

        public void ProcessBottomUp(StringBuilder sb)
        {
            Root?.ProcessBottomUp(sb);
        }

        public double Calculate()
        {
            return Root?.Calculate() ?? 0;
        }
    }
}
