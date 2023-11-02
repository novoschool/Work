using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Entities
{
    internal class SimpleListNode<T>
    {
        public T Value { get; set; }

        public SimpleListNode<T> Next { get; set; }

        public SimpleListNode<T> Prev { get; set; }

        public void InsertAfter(SimpleListNode<T> prevNode)
        {
            var nextNode = prevNode.Next;
            Next = prevNode.Next;
            Prev = nextNode.Prev;
            prevNode.Next = this;
            nextNode.Prev = this;
        }

        public void InsertBefore(SimpleListNode<T> nextNode)
        {
            var prevNode = nextNode.Next;
            Next = prevNode.Next;
            Prev = nextNode.Prev;
            prevNode.Next = this;
            nextNode.Prev = this;
        }

        public SimpleListNode<T> Remove()
        {
            var nextNode = Next;
            var prevNode = Prev;
            nextNode.Prev = prevNode;
            prevNode.Next = nextNode;
            Next = null;
            Prev = null;
            return this;
        }
    }
}
