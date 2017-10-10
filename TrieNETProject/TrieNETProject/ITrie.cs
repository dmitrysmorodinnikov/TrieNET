using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieNETProject
{
    interface ITrie
    {
        void Add(string word);
        bool ContainsWord(string word);
        bool ContainsPrefix(string prefix);
    }
}
