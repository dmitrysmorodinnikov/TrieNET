using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNET;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class ContainsWordTest3
    {
        private Trie ActualTrie;

        [TestInitialize]
        public void Init()
        {
            ActualTrie = TestTries.Get(2);
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
            Assert.IsTrue(ActualTrie.Search("abc"));
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

        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsTrue(ActualTrie.Search("abgl"));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(ActualTrie.Search("cdf"));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.IsTrue(ActualTrie.Search("lmn"));
        }
    }
}
