using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNETProject;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class InsertionTest1
    {
        private Trie DesiredTrie;
        private Trie ActualTrie;

        [TestInitialize]
        public void Init()
        {
            var root = new TrieNode();
            ActualTrie = new Trie(root);
            ActualTrie.Add("abc");
        }

        [TestMethod]
        public void TestMethod1()
        {
            DesiredTrie = TestTries.Get(0);
            Assert.IsTrue(new TrieNodeEqualityComparer().Equals(DesiredTrie.Root, ActualTrie.Root));
        }

        [TestMethod]
        public void TestMethod2()
        {
            DesiredTrie = TestTries.Get(1);
            Assert.IsFalse(new TrieNodeEqualityComparer().Equals(DesiredTrie.Root, ActualTrie.Root));
        }
    }
}
