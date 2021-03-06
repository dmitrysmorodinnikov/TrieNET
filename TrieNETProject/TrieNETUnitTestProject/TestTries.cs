﻿using System.Collections.Generic;
using TrieNET;

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
            Instances.Add(Create3());
        }

        private static Trie Create1()//"abc"
        {
            var trie = new Trie();
            var bTrieNode = new TrieNode();
            var cTrieNode = new TrieNode();
            var endTrieNode = new TrieNode(true);
            trie.Root.Children.Add('a', bTrieNode);
            bTrieNode.Children.Add('b', cTrieNode);
            cTrieNode.Children.Add('c', endTrieNode);

            return trie;
        }

        private static Trie Create2()//"abcd"
        {
            var trie = new Trie();
            var bTrieNode = new TrieNode();
            var cTrieNode = new TrieNode();
            var dTrieNode = new TrieNode();
            var endTrieNode = new TrieNode(true);
            trie.Root.Children.Add('a', bTrieNode);
            bTrieNode.Children.Add('b', cTrieNode);
            cTrieNode.Children.Add('c', dTrieNode);
            dTrieNode.Children.Add('d', endTrieNode);

            return trie;
        }

        private static Trie Create3()//"abc","abgl","cd","abcd", "lmn"
        {
            var trie = new Trie();
            var bTrieNode = new TrieNode();
            var lTrieNode = new TrieNode();
            var d1TrieNode = new TrieNode();
            var d2TrieNode = new TrieNode(true);
            var mTrieNode = new TrieNode();
            var nTrieNode = new TrieNode();
            var cgTrieNode = new TrieNode();
            var fTrieNode = new TrieNode();
            var endTrieNode1 = new TrieNode(true);
            var endTrieNode2 = new TrieNode(true);
            var endTrieNode3 = new TrieNode(true);
            var endTrieNode4 = new TrieNode(true);

            trie.Root.Children.Add('a', bTrieNode);
            trie.Root.Children.Add('c', d1TrieNode);
            trie.Root.Children.Add('l', mTrieNode);
            bTrieNode.Children.Add('b', cgTrieNode);
            cgTrieNode.Children.Add('c', d2TrieNode);
            cgTrieNode.Children.Add('g', lTrieNode);
            lTrieNode.Children.Add('l', endTrieNode2);
            d2TrieNode.Children.Add('d', endTrieNode1);

            d1TrieNode.Children.Add('d', fTrieNode);
            fTrieNode.Children.Add('f', endTrieNode3);

            mTrieNode.Children.Add('m', nTrieNode);
            nTrieNode.Children.Add('n', endTrieNode4);

            return trie;
        }
    }
}
