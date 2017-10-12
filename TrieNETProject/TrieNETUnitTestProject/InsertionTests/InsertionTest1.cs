using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNET;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class InsertionTest1
    {
        private Trie _desiredTrie;
        private Trie _actualTrie;

        [TestInitialize]
        public void Init()
        {            
            _actualTrie = new Trie();
            _actualTrie.Insert("abc");
        }

        [TestMethod]
        public void TestMethod1()
        {
            _desiredTrie = TestTries.Get(0);
            Assert.IsTrue(new TrieNodeEqualityComparer().Equals(_desiredTrie.Root, _actualTrie.Root));
        }

        [TestMethod]
        public void TestMethod2()
        {
            _desiredTrie = TestTries.Get(1);
            Assert.IsFalse(new TrieNodeEqualityComparer().Equals(_desiredTrie.Root, _actualTrie.Root));
        }

        [TestMethod]
        public void TestMethod3()
        {
            _desiredTrie = TestTries.Get(2);
            Assert.IsFalse(new TrieNodeEqualityComparer().Equals(_desiredTrie.Root, _actualTrie.Root));
        }
    }
}
