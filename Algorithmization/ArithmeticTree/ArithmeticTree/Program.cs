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
            };

            tree.Root = rootNode;
            var leftNode = new TreeNode
            {
                Type = TreeNodeType.Operation,
                OpCode = "+",
                Left = new TreeNode
                {
                    Type = TreeNodeType.Number,
                    Number = 5,
                },
                Right = new TreeNode
                {
                    Type = TreeNodeType.Number,
                    Number = 3,
                },
            };

            var rightNode = new TreeNode
            {
                Type = TreeNodeType.Operation,
                OpCode = "-",
                Left = new TreeNode
                {
                    Type = TreeNodeType.Number,
                    Number = 8,
                },
                Right = new TreeNode
                {
                    Type = TreeNodeType.Number,
                    Number = 2,
                },
            };

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
        }
    }
}