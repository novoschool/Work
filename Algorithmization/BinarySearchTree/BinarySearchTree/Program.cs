using BinarySearchTree.Entities;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>((a, b) => a < b ? -1 : a == b ? 0 : 1);
            var rnd = new Random();

            for (int i = 0; i < 40; i++)
            {
                var value = 2 * i + rnd.Next(20);
                var (inserted, node) = tree.Insert(value);
                if (inserted)
                {
                    Console.WriteLine($"Value {value} was inserted to tree.");
                }
                else
                {
                    Console.WriteLine($"Value {value} already existed in tree.");
                }
            }

            tree.ProcessLeftToRight((x, level) => Console.Write($"{x}[{level}] "));
            Console.WriteLine();

            foreach (var value in new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 })
            {
                var searchResult = tree.Search(value);
                if (searchResult != null)
                {
                    Console.WriteLine($"Value {value} found.");
                }
                else
                {
                    Console.WriteLine($"Value {value} not found.");
                }
            }
        }
    }
}