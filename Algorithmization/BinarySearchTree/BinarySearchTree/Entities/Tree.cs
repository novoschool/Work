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

        public void ProcessLeftToRight(Action<T, int> action)
        {
            Root?.ProcessLeftToRight(action, 0);
        }

        public TreeNode<T> Search(T value)
        {
            return Root?.Search(value, CompareFunc);
        }

        public (bool, TreeNode<T>) Insert(T value)
        {
            if (Root != null)
            {
                return Root.Insert(value, CompareFunc);
            }

            Root = new TreeNode<T>
            {
                Value = value,
                Left = null,
                Right = null,
                Parent = null,
            };

            return (true, Root);
        }
    }
}
