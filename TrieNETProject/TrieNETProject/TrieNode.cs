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

        public void Add(string w, TrieNode root)
        {
            if(string.IsNullOrEmpty(w))
                return;
            TrieNode curr = root;
            for (int i = 0; i < w.Length - 1; i++)
            {
                var node = AddCh(w[i], false, curr);
                curr = node;
            }
            //add last char
            AddCh(w.Last(), true, curr);
        }

        private TrieNode AddCh(char ch, bool isLast, TrieNode curr)
        {
            if (curr.Children.ContainsKey(ch))
                return curr.Children[ch];
            var trieNode = new TrieNode(isLast);
            curr.Children.Add(ch, trieNode);
            return trieNode;
        }
    }
}
