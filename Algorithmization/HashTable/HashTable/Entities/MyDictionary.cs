using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.Entities
{
    public class MyDictionary<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private readonly MyHashTable<TKey, TValue> _hashTable = new();

        public bool Add(TKey key, TValue value)
        {
            return _hashTable.Add(key, value);
        }

        public TValue? Get(TKey key)
        {
            return _hashTable.Get(key);
        }

        public bool Remove(TKey key)
        {
            return _hashTable.Remove(key);
        }

        public int Count => _hashTable.Count;

        public void Clear() 
        {
            _hashTable.Clear();
        }

        public void Enumerate(Action<TKey, TValue?> action)
        {
            _hashTable.Enumerate(action);
        }

        public TValue? this[TKey key]
        {
            get
            {
                return _hashTable.Get(key);
            }
            set
            {
                if (value == null)
                {
                    _hashTable.Remove(key);
                    return;
                }

                _hashTable.Add(key, value);
            }
        }
    }
}
