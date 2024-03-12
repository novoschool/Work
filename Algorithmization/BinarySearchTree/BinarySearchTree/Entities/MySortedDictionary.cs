using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Entities
{
    public class MySortedDictionary<TKey, TValue> where TKey : IComparable<TKey>
    {
        private Tree<KeyValuePair> _tree = new Tree<KeyValuePair>((x, y) => x.Key.CompareTo(y.Key));

        public bool Add(TKey key, TValue value)
        {
            var node = _tree.Search(new KeyValuePair { Key = key, });
            if (node != null)
            {
                node.Value.Value = value;
                return false;
            }

            _tree.Insert(new KeyValuePair { Key = key, Value = value, });
            return true;
        }

        public TValue? Get(TKey key)
        {
            var node = _tree.Search(new KeyValuePair { Key = key, });
            if (node != null)
            {
                return node.Value.Value;
            }

            return default;
        }

        public TValue? this[TKey key]
        {
            get
            {
                return Get(key);
            }
            set
            {
                if (value == null)
                {
                    _tree.Remove(new KeyValuePair { Key = key, });
                    return;
                }

                Add(key, value);
            }
        }

        public void ProcessLeftToRight(Action<KeyValuePair, int> action)
        {
            _tree.ProcessLeftToRight(action);
        }

        public class KeyValuePair
        {
            public TKey Key { get; set; }

            public TValue Value { get; set; }
        }
    }
}
