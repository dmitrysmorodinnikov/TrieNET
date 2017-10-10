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
}
