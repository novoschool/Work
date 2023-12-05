using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Entities
{
    internal class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public Func<T, T, int> CompareFunc { get; private set; }

        public Tree(Func<T, T, int> compareFunc)
        {
            CompareFunc = compareFunc;
        }

        public void ProcessLeftToRight(Action<T> action)
        {
            Root?.ProcessLeftToRight(action);
        }
    }
}
