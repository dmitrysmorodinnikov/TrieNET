using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNET;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class StartsWithTest1
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
            Assert.IsTrue(ActualTrie.StartsWith("a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(ActualTrie.StartsWith("ab"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(ActualTrie.StartsWith("abc"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(ActualTrie.StartsWith("abcd"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsFalse(ActualTrie.StartsWith("ak"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsFalse(ActualTrie.StartsWith("t"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsFalse(ActualTrie.StartsWith("12345"));
        }
    }
}
