using NewLinkedLists.Entities;

namespace NewLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new SingleLinkList<int>();
            list.Head = new SingleLinkListNode<int> { Value = 5 };
            list.Head.Next = new SingleLinkListNode<int> { Value = 10 };

            ShowList(list);

            var newNode = new SingleLinkListNode<int> { Value = 15 };
            newNode.InsertAfter(list.Head);

            ShowList(list);

            newNode = new SingleLinkListNode<int> { Value = 20 };
            list.InsertFirst(newNode);

            ShowList(list);

            newNode = new SingleLinkListNode<int> { Value = 25 };
            list.InsertLast(newNode);

            ShowList(list);

            var node = list.Head.RemoveNext();
            list.InsertLast(node);

            ShowList(list);

            node = list.RemoveFirst();
            list.InsertLast(node);

            ShowList(list);

            node = list.RemoveLast();
            list.InsertFirst(node);

            ShowList(list);
        }

        static void ShowList<T>(SingleLinkList<T> list)
        {
            var node = list.Head;

            while (node != null)
            {
                Console.Write($"{node.Value?.ToString()} ");
                node = node.Next;
            }

            Console.WriteLine();
        }
    }
}