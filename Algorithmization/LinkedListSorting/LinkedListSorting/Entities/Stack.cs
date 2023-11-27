using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSorting.Entities
{
    internal class Stack<T>
    {
        internal DoubleLinkedList<T> List = new DoubleLinkedList<T>();

        public int Count => List.Count;

        public void Push(T value)
        {
            List.InsertFirst(new DoubleLinkedListNode<T> { Value = value });
        }

        public T Pop()
        {
            if (List.Count > 0)
            {
                var node = List.RemoveFirst();
                return node.Value;
            }

            return default;
        }

        public T Top()
        {
            if (List.Count > 0)
            {
                var node = List.Head;
                return node.Value;
            }

            return default;
        }
    }
}
