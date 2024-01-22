using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Entities
{
    public class MyKey : IComparable<MyKey>
    {
        public string Field1 { get; set; }

        public int Field2 { get; set; }

        public int CompareTo(MyKey? other)
        {
            if (other == null)
            {
                return 1;
            }

            var compareResult = Field1.CompareTo(other.Field1);
            if (compareResult != 0)
            {
                return compareResult;
            }

            if (Field2 < other.Field2)
            {
                return -1;
            }

            if (Field2 > other.Field2)
            {
                return 1;
            }

            return 0;
        }
    }
}
