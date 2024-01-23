using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.Entities
{
    public class MyHashTable<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private const int InitialArraySize = 13;

        private const int MaxFilledPercent = 70;

        private KeyValuePair[] _dataSet = new KeyValuePair[InitialArraySize];

        public int Count { get; private set; }

        public TValue? Get(TKey key)
        {
            return default;
        }

        public bool Add(TKey key, TValue value)
        {
            var hash = key.GetHashCode();
            var index = hash % _dataSet.Length;

            while (_dataSet[index] != null)
            {
                if (_dataSet[index].Key.Equals(key))
                {
                    _dataSet[index].Value = value;
                    return false;
                }

                index = GetNextIndex(key, index, _dataSet.Length);
            }

            _dataSet[index] = new KeyValuePair { Key = key, Value = value };
            Count++;
            CheckAndRefill();
            return true;
        }

        private int GetNextIndex(TKey key, int index, int count)
        {
            index++;
            if (index == count)
            {
                index = 0;
            }

            return index;
        }

        private void CheckAndRefill()
        {
            if (_dataSet.Length * MaxFilledPercent < Count * 100)
            {
                return;
            }

            var newArraySize = _dataSet.Length * 2 + 1;
            var newArray = new KeyValuePair[newArraySize];
            foreach (var kvp in _dataSet)
            {
                if (kvp == null)
                {
                    continue;
                }

                var hash = kvp.Key.GetHashCode();
                var index = hash % newArraySize;

                while (newArray[index] != null)
                {
                    if (newArray[index].Key.Equals(kvp.Key))
                    {
                        newArray[index].Value = kvp.Value;
                        goto outerLoop;
                    }

                    index = GetNextIndex(kvp.Key, index, newArraySize);
                }

                newArray[index] = kvp;
            outerLoop:
                ;
            }

            _dataSet = newArray;
        }

        internal class KeyValuePair
        {
            public TKey Key { get; set; }

            public TValue Value { get; set; }
        }
    }
}
