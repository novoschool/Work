using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Entities
{
    internal class TreeNode<T>
    {
        public T Value { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public void ProcessLeftToRight(Action<T> action)
        {
            Left?.ProcessLeftToRight(action);
            action(Value);
            Right?.ProcessLeftToRight(action);
        }
    }
}
