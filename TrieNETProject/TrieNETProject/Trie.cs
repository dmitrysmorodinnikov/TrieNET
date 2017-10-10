using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieNETProject
{
    public class Trie : ITrie
    {
        public TrieNode Root { get; private set; }

        public Trie(TrieNode root)
        {
            Root = root;
        }

        public void Add(string w)
        {
            if (string.IsNullOrEmpty(w))
                return;
            TrieNode curr = Root;
            for (int i = 0; i < w.Length - 1; i++)
            {
                var node = AddCh(w[i], false, curr);
                curr = node;
            }
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

        public bool ContainsWord(string word)
        {
            var curr = Root;
            foreach (var ch in word)
            {
                curr = ChInTrie(ch, curr);
                if (curr == null)
                    return false;
            }
            return curr.EndOfWord;
        }

        public bool ContainsPrefix(string prefix)
        {
            var curr = Root;
            foreach (var ch in prefix)
            {
                curr = ChInTrie(ch, curr);
                if (curr == null)
                    return false;
            }
            return true;
        }

        private TrieNode ChInTrie(char ch, TrieNode curr)
        {
            return curr.Children.ContainsKey(ch) ? curr.Children[ch] : null;
        }
    }
}
