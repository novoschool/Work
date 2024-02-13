using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.Entities
{
    internal class Complekts : IEquatable<Complekts>
    {
        public string StringProperty { get; set; }

        public int IntProperty { get; set; }

        public bool Equals(Complekts? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (StringProperty != other.StringProperty)
            {
                return false;
            }

            return IntProperty == other.IntProperty;
        }
    }
}
