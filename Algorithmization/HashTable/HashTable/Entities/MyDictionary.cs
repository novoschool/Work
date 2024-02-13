using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.Entities
{
    public class MyDictionary<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private readonly MyHashTable<TKey, TValue> _dictionary = new();

        public TValue? GetValue(TKey key)
        {
            return _dictionary.Get(key);
        }

        public bool Add(TKey key, TValue value)
        {
            return _dictionary.Add(key, value);
        }

        public bool Remove(TKey key)
        {
            return _dictionary.Remove(key);
        }

        public int Count => _dictionary.Count;

        public TValue? this[TKey key]
        {
            get
            {
                return _dictionary.Get(key);
            }
            set
            {
                if (value == null)
                {
                    _dictionary.Remove(key);
                    return;
                }

                _dictionary.Add(key, value);
            }
        }
    }
}
