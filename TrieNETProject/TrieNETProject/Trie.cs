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

        public void Add(string word)
        {
            throw new NotImplementedException();
        }

        public bool ContainsWord(string word)
        {
            throw new NotImplementedException();
        }

        public bool ContainsPrefix(string prefix)
        {
            throw new NotImplementedException();
        }
    }
}
