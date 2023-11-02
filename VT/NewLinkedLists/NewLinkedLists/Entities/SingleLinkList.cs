using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLinkedLists.Entities
{
    internal class SingleLinkList<T>
    {
        public SingleLinkListNode<T> Head { get; set; }

        public bool InsertFirst(SingleLinkListNode<T> node)
        {
            if (node.Next != null)
            {
                return false;
            }

            for (var n = Head; n != null; n = n.Next)
            {
                if (n == node)
                {
                    return false;
                }
            }

            if (Head == null)
            {
                Head = node;
                return true;
            }

            node.Next = Head;
            Head = node;
            return true;
        }

        public bool InsertLast(SingleLinkListNode<T> node)
        {
            if (node.Next != null)
            {
                return false;
            }

            var lastNode = Head;
            for (var n = Head; n != null; n = n.Next)
            {
                if (n == node)
                {
                    return false;
                }

                lastNode = n;
            }

            if (Head == null)
            {
                Head = node;
                return true;
            }

            node.InsertAfter(lastNode);
            return true;
        }

        public SingleLinkListNode<T> RemoveFirst()
        {
            var node = Head;
            if (Head == null)
            {
                return node;
            }

            if (node.Next == null)
            {
                Head = null;
                return node;
            }

            Head = node.Next;
            node.Next = null;
            return node;
        }

        public SingleLinkListNode<T> RemoveLast()
        {
            var node = Head;
            if (Head == null)
            {
                return node;
            }

            if (node.Next == null)
            {
                Head = null;
                return node;
            }

            while (node.Next.Next != null)
            {
                node = node.Next;
            }

            return node.RemoveNext();
        }
    }
}
