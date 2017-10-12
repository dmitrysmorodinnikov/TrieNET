using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNET;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class SearchTest2
    {
        private Trie ActualTrie;

        [TestInitialize]
        public void Init()
        {
            ActualTrie = TestTries.Get(1);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(ActualTrie.Search("a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(ActualTrie.Search("ab"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(ActualTrie.Search("abcd"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(ActualTrie.Search("abc"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsFalse(ActualTrie.Search("ak"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsFalse(ActualTrie.Search("t"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsFalse(ActualTrie.Search("12345"));
        }
    }
}
