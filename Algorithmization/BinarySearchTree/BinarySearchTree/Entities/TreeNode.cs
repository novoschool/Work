using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Entities
{
    internal class TreeNode<T>
    {
        public T? Value { get; set; }

        public TreeNode<T>? Left { get; set; }

        public TreeNode<T>? Right { get; set; }

        public TreeNode<T>? Parent { get; set; }

        public void ProcessLeftToRight(Action<T?, int> action, int level)
        {
            Left?.ProcessLeftToRight(action, level + 1);
            action(Value, level);
            Right?.ProcessLeftToRight(action, level + 1);
        }

        public TreeNode<T>? Search(T value, Func<T, T, int> compare)
        {
            var compareResult = compare(value, Value);
            if (compareResult == 0)
            {
                return this;
            }

            if (compareResult < 0)
            {
                return Left?.Search(value, compare);
            }

            return Right?.Search(value, compare);
        }

        public (bool, TreeNode<T>) Insert(T value, Func<T, T, int> compare)
        {
            var compareResult = compare(value, Value);
            if (compareResult == 0)
            {
                return (false, this);
            }

            if (compareResult < 0)
            {
                if (Left != null)
                {
                    return Left.Insert(value, compare);
                }

                Left = CreateNode(value);
                return (true, Left);
            }

            if (Right != null)
            {
                return Right.Insert(value, compare);
            }

            Right = CreateNode(value);
            return (true, Right);
        }

        private TreeNode<T> CreateNode(T value)
        {
            return new TreeNode<T>
            {
                Value = value,
                Left = null,
                Right = null,
                Parent = this,
            };
        }
    }
}
