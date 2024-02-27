using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Entities
{
    internal class SimpleList<T>
    {
        public SimpleListNode<T> Head { get; set; }

        public SimpleListNode<T> Tail { get; set; }

        public void InsertFirst(SimpleListNode<T> node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                node.Next = null;
                node.Prev = null;
            }
            else
            {
                node.Next = Head;
                node.Prev = null;
                Head.Prev = node;
                Head = node;
            }
        }

        public void InsertLast(SimpleListNode<T> node)
        {
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                node.Next = null;
                node.Prev = null;
            }
            else
            {
                node.Prev = Tail;
                node.Next = null;
                Tail.Next = node;
                Tail = node;
            }
        }

        public SimpleListNode<T> FindPrevNode(SimpleListNode<T> node)
        {
            var p = Head;
            while (p != null && p.Next != node)
            {
                p = p.Next;
            }

            return p;
        }

        public SimpleListNode<T> Find(T value, Func<T, T, bool> compare)
        {
            var p = Head;
            while (p != null && !compare(p.Value, value))
            {
                p = p.Next;
            }

            return p;
        }
    }
}
