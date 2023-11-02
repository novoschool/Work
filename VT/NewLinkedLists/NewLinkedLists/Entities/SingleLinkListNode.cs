using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLinkedLists.Entities
{
    internal class SingleLinkListNode<T>
    {
        public T Value { get; set; }

        public SingleLinkListNode<T> Next { get; set; }

        public void InsertAfter(SingleLinkListNode<T> node)
        {
            Next = node.Next;
            node.Next = this;
        }

        public SingleLinkListNode<T> RemoveNext()
        {
            if (Next == null)
            {
                return null;
            }

            var result = Next;
            Next = result.Next;
            result.Next = null;

            return result;
        }
    }
}
