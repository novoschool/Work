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

        public bool Remove(T value)
        {
            var node = Search(value);
            if (node == null)
            {
                return false;
            }

            if (node.Right == null)
            {
                var parent = node.Parent;
                var left = node.Left;
                if (parent != null)
                {
                    if (parent.Right == node)
                    {
                        parent.Right = left;
                    }
                    else
                    {
                        parent.Left = left;
                    }
                }
                else
                {
                    Root = left;
                }

                if (left != null)
                {
                    left.Parent = parent;
                }

                node.Left = null;
                node.Parent = null;
            }
            else if (node.Left == null)
            {
                var parent = node.Parent;
                var right = node.Right;
                if (parent != null)
                {
                    if (parent.Right == node)
                    {
                        parent.Right = right;
                    }
                    else
                    {
                        parent.Left = right;
                    }
                }
                else
                {
                    Root = right;
                }

                right.Parent = parent;
                node.Left = null;
                node.Parent = null;
            }
            else
            {
                var nodeToReplace = FindLeftmost(node.Right);
                node.Value = nodeToReplace.Value;
                var parent = nodeToReplace.Parent;
                if (parent.Right == nodeToReplace)
                {
                    parent.Right = nodeToReplace.Right;
                }
                else
                {
                    parent.Left = nodeToReplace.Right;
                }

                if (nodeToReplace.Right != null)
                {
                    nodeToReplace.Right.Parent = parent;
                }
                else
                {
                    nodeToReplace.Parent = null;
                }
            }

            return true;
        }

        private TreeNode<T> FindLeftmost(TreeNode<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }
    }
}
