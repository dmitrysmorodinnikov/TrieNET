using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieNETProject
{
    public class TrieNode
    {
        public bool EndOfWord { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; }

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
        }

        public TrieNode(bool isLast)
        {
            Children = new Dictionary<char, TrieNode>();
            EndOfWord = isLast;
        }
    }

    public class TrieNodeEqualityComparer : IEqualityComparer<TrieNode>
    {
        public bool Equals(TrieNode x, TrieNode y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null || x.EndOfWord != y.EndOfWord)
                return false;
            foreach (var xPair in x.Children)
            {
                if (!y.Children.ContainsKey(xPair.Key))
                    return false;
                if (!Equals(y.Children[xPair.Key], xPair.Value))
                    return false;
            }
            return true;
        }

        public int GetHashCode(TrieNode obj)
        {
            return base.GetHashCode();
        }
    }
}
