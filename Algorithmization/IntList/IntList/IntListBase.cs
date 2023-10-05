using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntList
{
    internal abstract class IntListBase
    {
        const uint InitialCapacity = 8;

        private int[] _values;

        private uint _count;

        protected uint _capacity;

        public IntListBase()
        {
            _capacity = InitialCapacity;
            _values = new int[_capacity];
            _count = 0;
        }

        public uint Count => _count;

        public int this[uint index]
        {
            get
            {
                if (index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }

                return _values[index];
            }
            set
            {
                if (index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }

                _values[index] = value;
            }
        }

        public void Add(int newValue)
        {
            if (_count == _capacity)
            {
                IncreaseArraySize();
            }

            _values[_count++] = newValue;
        }

        private void IncreaseArraySize()
        {
            var newCapacity = GetNewArraySize();
            var newArray = new int[newCapacity];
            for (int i = 0; i < _capacity; i++)
            {
                newArray[i] = _values[i];
            }

            _capacity = newCapacity;
            _values = newArray;
        }

        protected abstract uint GetNewArraySize();
    }
}
