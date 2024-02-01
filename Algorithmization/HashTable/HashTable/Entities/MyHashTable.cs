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

        private KeyValuePair?[] _dataSet = new KeyValuePair[InitialArraySize];

        public int Count { get; private set; }

        private int _busyCount = 0;

        public TValue? Get(TKey key)
        {
            var hash = (uint)key.GetHashCode();
            var index = hash % _dataSet.LongLength;

            while (_dataSet[index] != null)
            {
                if (_dataSet[index].Key.Equals(key))
                {
                    if (_dataSet[index].IsRemoved)
                    {
                        return default;
                    }

                    return _dataSet[index].Value;
                }

                index = GetNextIndex(key, index, _dataSet.Length);
            }

            return default;
        }

        public bool Add(TKey key, TValue value)
        {
            var hash = (uint)key.GetHashCode();
            var index = hash % _dataSet.LongLength;

            while (_dataSet[index] != null)
            {
                if (_dataSet[index].Key.Equals(key))
                {
                    _dataSet[index].Value = value;
                    if (_dataSet[index].IsRemoved)
                    {
                        _dataSet[index].IsRemoved = false;
                        Count++;
                    }

                    return false;
                }

                index = GetNextIndex(key, index, _dataSet.Length);
            }

            _dataSet[index] = new KeyValuePair { Key = key, Value = value };
            Count++;
            _busyCount++;
            CheckAndRefill();
            return true;
        }

        public bool Remove(TKey key)
        {
            var hash = (uint)key.GetHashCode();
            var index = hash % _dataSet.LongLength;

            while (_dataSet[index] != null)
            {
                if (_dataSet[index].Key.Equals(key))
                {
                    if (_dataSet[index].IsRemoved)
                    {
                        return false;
                    }

                    _dataSet[index].IsRemoved = true;
                    Count--;
                    return true;
                }

                index = GetNextIndex(key, index, _dataSet.Length);
            }

            return false;
        }

        private long GetNextIndex(TKey key, long index, long count)
        {
            var hashCode = (uint)key.GetHashCode();
            var indexStep = hashCode % (_dataSet.LongLength - 1) + 1;
            index += indexStep;
            if (index >= count)
            {
                index -= count;
            }

            return index;
        }

        private void CheckAndRefill()
        {
            if (_dataSet.Length * MaxFilledPercent > _busyCount * 100)
            {
                return;
            }

            var newArraySize = _dataSet.LongLength * 2 + 1;
            while (!IsPrime(newArraySize))
            {
                newArraySize += 2;
            }

            var newArray = new KeyValuePair[newArraySize];
            foreach (var kvp in _dataSet)
            {
                if (kvp == null || kvp.IsRemoved)
                {
                    continue;
                }

                var hash = (uint)kvp.Key.GetHashCode();
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
            _busyCount = Count;
        }

        private bool IsPrime(long number)
        {
            if (number % 2 == 0)
            {
                return false;
            }

            var divider = 3;
            while (divider * divider <= number)
            {
                if (number % divider == 0)
                {
                    return false;
                }

                divider += 2;
            }

            return true;
        }

        internal class KeyValuePair
        {
            public TKey Key { get; set; }

            public TValue? Value { get; set; }

            public bool IsRemoved { get; set; }
        }
    }
}
