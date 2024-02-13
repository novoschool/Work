using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.Entities
{
    internal class MyDictionary<Tkey, TValue> where Tkey : IEquatable<Tkey>
    {
        private readonly MyDictionary<Tkey, TValue> _dictionry = new();

        public TValue? GetValue(Tkey key)
        {
            return _dictionry.GetValue(key);
        }

        public bool Add(Tkey key, TValue value)
        {
            return _dictionry.Add(key, value);
        }

        public bool Remove(Tkey key)
        {
            return _dictionry.Remove(key);
        }

        public bool Count => _dictionry.Count;

        public TValue? this[Tkey key]
        {
            get
            {
                return _dictionry.GetValue(key);
            }
            set
            {
                if (value == null)
                {
                    _dictionry.Remove(key);
                    return;
                }

                _dictionry.Add(key, value);
            }
        }
    }
}
