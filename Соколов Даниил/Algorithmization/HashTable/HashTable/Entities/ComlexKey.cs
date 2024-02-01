using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.Entities
{
    public class ComlexKey : IEquatable<ComlexKey>
    {
        public string StringProperty { get; set; }

        public int IntProperty { get; set; }

        public bool Equals(ComlexKey? other)
        {
            //throw new NotImplementedException();

            if (ReferenceEquals(this, other)) return false;

            if (StringProperty != other.StringProperty) return false;

            return IntProperty == other.IntProperty;
        }

        public override int GetHashCode()
        {
            //return $"{StringProperty}_{IntProperty}".GetHashCode();
            return StringProperty.GetHashCode() + IntProperty.GetHashCode();
        }
    }
}
