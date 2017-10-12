namespace TrieNET
{
    interface ITrie
    {
        void Insert(string word);
        bool Search(string word);
        bool StartsWith(string prefix);
    }
}
