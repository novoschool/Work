using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree.Entities
{
    internal class TreeLeftToRightIterator : ITreeIterator
    {
        private Tree _tree;

        private TreeNode? _currentNode;

        public TreeLeftToRightIterator(Tree tree)
        {
            _tree = tree;
            Reset();
        }

        public TreeNode? Current => _currentNode;

        public void MoveNext()
        {
            if (_currentNode == null)
            {
                return;
            }

            if (_currentNode.Right != null)
            {
                var node = _currentNode.Right;
                while (node.Left != null)
                {
                    node = node.Left;
                }

                _currentNode = node;
                return;
            }

            var curNode = _currentNode;
            var nextNode = _currentNode.Parent;
            while (nextNode != null && nextNode.Left != curNode)
            {
                curNode = nextNode;
                nextNode = nextNode.Parent;
            }

            _currentNode = nextNode;
        }

        public void Reset()
        {
            var node = _tree.Root;
            if (node == null)
            {
                _currentNode = null;
                return;
            }

            while (node.Left != null)
            {
                node = node.Left;
            }

            _currentNode = node;
        }
    }
}
