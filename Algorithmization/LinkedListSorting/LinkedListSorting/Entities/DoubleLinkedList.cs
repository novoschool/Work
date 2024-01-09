using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSorting.Entities
{
    internal class DoubleLinkedList<T>
    {
        public DoubleLinkedListNode<T> Head { get; private set; }

        public DoubleLinkedListNode<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void InsertFirst(DoubleLinkedListNode<T> node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                Count++;
                return;
            }

            node.Next = Head;
            Head.Prev = node;
            Head = node;
            Count++;
        }

        public void InsertLast(DoubleLinkedListNode<T> node)
        {
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                Count++;
                return;
            }

            node.Prev = Tail;
            Tail.Next = node;
            Tail = node;
            Count++;
        }

        public DoubleLinkedListNode<T> RemoveFirst()
        {
            if (Head == null)
            {
                return null;
            }

            var node = Head;
            if (node.Next == null)
            {
                Head = null;
                Tail = null;
                Count--;
                return node;
            }

            Head = node.Next;
            Head.Prev = null;
            node.Next = null;
            Count--;
            return node;
        }

        public DoubleLinkedListNode<T> RemoveLast()
        {
            if (Tail == null)
            {
                return null;
            }

            var node = Tail;
            if (node.Prev == null)
            {
                Head = null;
                Tail = null;
                Count--;
                return node;
            }

            Tail = node.Prev;
            Tail.Next = null;
            node.Prev = null;
            Count--;
            return node;
        }
    }
}
