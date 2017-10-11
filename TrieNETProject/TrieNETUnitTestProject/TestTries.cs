using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrieNETProject;

namespace TrieNETUnitTestProject
{
    internal static class TestTries
    {
        private static IList<Trie> Instances = new List<Trie>();

        static TestTries()
        {
            AddToInstances();
        }

        internal static Trie Get(int index)
        {
            return Instances[index];
        }

        private static void AddToInstances()
        {
            Instances.Add(Create1());
            Instances.Add(Create2());
        }

        private static Trie Create1()//"abc"
        {
            var root = new TrieNode();
            var bTrieNode = new TrieNode();
            var cTrieNode = new TrieNode();
            var endTrieNode = new TrieNode(true);
            root.Children.Add('a', bTrieNode);
            bTrieNode.Children.Add('b', cTrieNode);
            cTrieNode.Children.Add('c', endTrieNode);

            return new Trie(root);
        }

        private static Trie Create2()//"abcd"
        {
            var root = new TrieNode();
            var bTrieNode = new TrieNode();
            var cTrieNode = new TrieNode();
            var dTrieNode = new TrieNode();
            var endTrieNode = new TrieNode(true);
            root.Children.Add('a', bTrieNode);
            bTrieNode.Children.Add('b', cTrieNode);
            cTrieNode.Children.Add('c', dTrieNode);
            cTrieNode.Children.Add('d', endTrieNode);

            return new Trie(root);
        }

        private static Trie Create3()//"abc","abgl","cd","abcd", "lmn"
        {
            throw new NotImplementedException();
            //var root = new TrieNode();
            //var bTrieNode = new TrieNode();
            //var cTrieNode = new TrieNode();
            //var endTrieNode = new TrieNode(true);
            //root.Children.Add('a', bTrieNode);
            //bTrieNode.Children.Add('b', cTrieNode);
            //cTrieNode.Children.Add('c', endTrieNode);

            //return new Trie(root);
        }
    }
}
