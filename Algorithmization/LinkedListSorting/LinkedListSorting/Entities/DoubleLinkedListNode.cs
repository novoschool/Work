using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSorting.Entities
{
    internal class DoubleLinkedListNode<T>
    {
        public T Value { get; set; }

        public DoubleLinkedListNode<T> Prev { get; set; }

        public DoubleLinkedListNode<T> Next { get; set; }
    }
}
