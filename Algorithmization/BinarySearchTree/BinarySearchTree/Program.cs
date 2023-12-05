using BinarySearchTree.Entities;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>((a, b) => a < b ? -1 : a == b ? 0 : 1);
            var rootNode = new TreeNode<int> { Value = 48 };
            tree.Root = rootNode;

            var leftSubTree = new TreeNode<int>
            {
                Value = 32,
                Left = new TreeNode<int>
                {
                    Value = 20,
                    Left = new TreeNode<int>
                    {
                        Value = 8,
                    },
                    Right = new TreeNode<int>
                    {
                        Value = 30,
                    },
                },
                Right = new TreeNode<int>
                {
                    Value = 40,
                    Right = new TreeNode<int>
                    {
                        Value = 44,
                    },
                },
            };

            tree.Root.Left = leftSubTree;

            tree.ProcessLeftToRight(x => Console.Write($"{x} "));
            Console.WriteLine();
        }
    }
}