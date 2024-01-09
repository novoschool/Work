using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSorting.Entities
{
    internal class Queue<T>
    {
        internal DoubleLinkedList<T> List = new DoubleLinkedList<T>();

        public int Count => List.Count;

        public void Enqueue(T value)
        {
            List.InsertFirst(new DoubleLinkedListNode<T> { Value = value });
        }

        public T Dequeue()
        {
            if (List.Count > 0)
            {
                var node = List.RemoveLast();
                return node.Value;
            }

            return default;
        }

        public T Peek()
        {
            if (List.Count > 0)
            {
                var node = List.Tail;
                return node.Value;
            }

            return default;
        }
    }
}
