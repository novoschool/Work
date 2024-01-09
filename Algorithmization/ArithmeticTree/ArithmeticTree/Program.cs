using ArithmeticTree.Entities;
using System.Text;

namespace ArithmeticTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            var rootNode = new TreeNode
            {
                Type = TreeNodeType.Operation,
                OpCode = "*",
                Parent = null,
            };

            tree.Root = rootNode;
            var leftNode = new TreeNode
            {
                Type = TreeNodeType.Operation,
                OpCode = "+",
                Parent = rootNode,
            };

            var subNode = new TreeNode
            {
                Type = TreeNodeType.Number,
                Number = 5,
                Parent = leftNode,
            };
            leftNode.Left = subNode;

            subNode = new TreeNode
            {
                Type = TreeNodeType.Number,
                Number = 3,
                Parent = leftNode,
            };
            leftNode.Right = subNode;

            var rightNode = new TreeNode
            {
                Type = TreeNodeType.Operation,
                OpCode = "-",
                Parent = rootNode,
            };

            subNode = new TreeNode
            {
                Type = TreeNodeType.Number,
                Number = 8,
                Parent = rightNode,
            };
            rightNode.Left = subNode;

            subNode = new TreeNode
            {
                Type = TreeNodeType.Number,
                Number = 2,
                Parent = rightNode,
            };
            rightNode.Right = subNode;

            rootNode.Left = leftNode;
            rootNode.Right = rightNode;

            var sb = new StringBuilder();
            tree.ProcessLeftToRight(sb);
            Console.WriteLine("Processed left to right:");
            Console.WriteLine(sb);

            sb.Clear();
            tree.ProcessTopDown(sb);
            Console.WriteLine("Processed top down:");
            Console.WriteLine(sb);

            sb.Clear();
            tree.ProcessBottomUp(sb);
            Console.WriteLine("Processed bottom up:");
            Console.WriteLine(sb);

            var result = tree.Calculate();
            Console.WriteLine($"Результат вычисления: {result}.");

            var it = new TreeLeftToRightIterator(tree);
            Console.WriteLine("Iterator run:");
            while (it.Current != null)
            {
                if (it.Current.Type == TreeNodeType.Operation)
                {
                    Console.Write($"{it.Current.OpCode} ");
                }
                else
                {
                    Console.Write($"{it.Current.Number} ");
                }

                it.MoveNext();
            }
        }
    }
}