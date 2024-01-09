using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSorting.Entities
{
    internal class Deque<T>
    {
        internal DoubleLinkedList<T> List = new DoubleLinkedList<T>();

        public int Count => List.Count;

        public void EnqueueFirst(T value)
        {
            List.InsertFirst(new DoubleLinkedListNode<T> { Value = value });
        }

        public void EnqueueLast(T value)
        {
            List.InsertLast(new DoubleLinkedListNode<T> { Value = value });
        }

        public T DequeueFirst()
        {
            if (List.Count > 0)
            {
                var node = List.RemoveFirst();
                return node.Value;
            }

            return default;
        }

        public T DequeueLast()
        {
            if (List.Count > 0)
            {
                var node = List.RemoveLast();
                return node.Value;
            }

            return default;
        }

        public T PeekFirst()
        {
            if (List.Count > 0)
            {
                var node = List.Head;
                return node.Value;
            }

            return default;
        }

        public T PeekLast()
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
