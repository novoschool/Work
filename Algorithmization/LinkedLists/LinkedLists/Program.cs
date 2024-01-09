using LinkedLists.Entities;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new SimpleList<int>();

            foreach (var value in new[] { 5, 10, 15 })
            {
                list.InsertLast(new SimpleListNode<int> { Value = value });
            }

            var newNode = new SimpleListNode<int>
            {
                Value = 55,
            };

            newNode.InsertAfter(list.Head);

            newNode = new SimpleListNode<int>
            {
                Value = 155,
            };

            list.InsertFirst(newNode);

            for (var node = list.Head; node != null; node = node.Next)
            {
                Console.Write($"{node.Value} ");
            }

            Console.WriteLine();

            foreach (var value in new[] { 5, 15, 25, 55 })
            {
                var foundNode = list.Find(value, (a, b) => a == b);
                if (foundNode != null)
                {
                    Console.WriteLine($"Value {value} found!");
                }
                else
                {
                    Console.WriteLine($"Value {value} not found!");
                }
            }

            var found = list.Find(55, (a, b) => a == b);
            if (found != null)
            {
                found.Remove();
            }

            for (var node = list.Head; node != null; node = node.Next)
            {
                Console.Write($"{node.Value} ");
            }

            Console.WriteLine();
        }
    }
}