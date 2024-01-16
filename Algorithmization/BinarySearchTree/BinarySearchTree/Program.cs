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
                var value = rnd.Next(100);
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

            var kvpTree = new Tree<Entities.KeyValuePair>((x, y) => x.Key < y.Key ? -1 : x.Key == y.Key ? 0 : 1);

            for (int i = 0; i < 80; i++)
            {
                var key = rnd.Next(100);
                var value = rnd.Next(100);
                var (inserted, node) = kvpTree.Insert(new Entities.KeyValuePair { Key = key, Value = value });
                if (inserted)
                {
                    Console.WriteLine($"Value ({key}, {value}) was inserted to tree.");
                }
                else
                {
                    Console.WriteLine($"Key {key} already existed in tree. Value {value} was not inserted.");
                }
            }

            kvpTree.ProcessLeftToRight((x, level) => Console.Write($"({x.Key}, {x.Value}) [{level}] "));
            Console.WriteLine();

            foreach (var key in new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 })
            {
                var searchResult = kvpTree.Search(new Entities.KeyValuePair { Key = key });
                if (searchResult != null)
                {
                    Console.WriteLine($"Key {key} found. Value = {searchResult.Value.Value}");
                }
                else
                {
                    Console.WriteLine($"Key {key} not found.");
                }
            }
        }
    }
}