using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNET;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class InsertionTest2
    {
        private Trie DesiredTrie;
        private Trie ActualTrie;

        [TestInitialize]
        public void Init()
        {
            ActualTrie = new Trie();
            ActualTrie.Insert("abcd");
        }

        [TestMethod]
        public void TestMethod1()
        {
            DesiredTrie = TestTries.Get(0);
            Assert.IsFalse(new TrieNodeEqualityComparer().Equals(DesiredTrie.Root, ActualTrie.Root));
        }

        [TestMethod]
        public void TestMethod2()
        {
            DesiredTrie = TestTries.Get(1);
            Assert.IsTrue(new TrieNodeEqualityComparer().Equals(DesiredTrie.Root, ActualTrie.Root));
        }

        [TestMethod]
        public void TestMethod3()
        {
            DesiredTrie = TestTries.Get(2);
            Assert.IsFalse(new TrieNodeEqualityComparer().Equals(DesiredTrie.Root, ActualTrie.Root));
        }
    }
}
