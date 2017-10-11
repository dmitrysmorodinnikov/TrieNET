using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNETProject;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class ContainsWordTest2
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
            Assert.IsFalse(ActualTrie.ContainsWord("a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(ActualTrie.ContainsWord("ab"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(ActualTrie.ContainsWord("abcd"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(ActualTrie.ContainsWord("abc"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsFalse(ActualTrie.ContainsWord("ak"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsFalse(ActualTrie.ContainsWord("t"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsFalse(ActualTrie.ContainsWord("12345"));
        }
    }
}
