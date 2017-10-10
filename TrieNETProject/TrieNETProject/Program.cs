using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieNETProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new TrieNode();
            var trie = new Trie(root);
            trie.Add("abc");
            trie.Add("abgl");
            trie.Add("cdf");
            trie.Add("abcd");
            trie.Add("lmn");

            var contains = trie.ContainsPrefix("cdf");
            var contains1 = trie.ContainsPrefix("cd");
            var contains2 = trie.ContainsPrefix("df");
            var contains3 = trie.ContainsPrefix("ml");
            var res = new List<bool>() {contains,contains1,contains2,contains3};
            
        }
    }
}
