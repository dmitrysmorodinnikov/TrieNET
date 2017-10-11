using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieNETProject
{
    public class Trie : ITrie
    {
        public TrieNode Root { get; }

        public Trie()
        {
            Root = new TrieNode();
        }

        //public Trie(TrieNode root)
        //{
        //    Root = root;
        //}

        public void Add(string w)
        {
            if (string.IsNullOrEmpty(w))
                return;
            TrieNode curr = Root;
            foreach (char ch in w)
            {
                var node = AddCh(ch, false, curr);
                curr = node;
            }
            curr.EndOfWord = true;
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
