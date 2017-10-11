using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNETProject;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class ContainsPrefixTest1
    {
        private Trie ActualTrie;

        [TestInitialize]
        public void Init()
        {
            ActualTrie = TestTries.Get(0);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("ab"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("abc"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("abcd"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("ak"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("t"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("12345"));
        }
    }
}
