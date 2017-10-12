using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNET;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class StartsWithTest3
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
            Assert.IsTrue(ActualTrie.StartsWith("a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(ActualTrie.StartsWith("c"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(ActualTrie.StartsWith("l"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(ActualTrie.StartsWith("ab"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(ActualTrie.StartsWith("abc"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(ActualTrie.StartsWith("abcd"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(ActualTrie.StartsWith("abg"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsTrue(ActualTrie.StartsWith("abgl"));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(ActualTrie.StartsWith("cd"));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.IsTrue(ActualTrie.StartsWith("cdf"));
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.IsTrue(ActualTrie.StartsWith("lm"));
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.IsTrue(ActualTrie.StartsWith("lmn"));
        }

        [TestMethod]
        public void TestMethod13()
        {
            Assert.IsFalse(ActualTrie.StartsWith("abd"));
        }

        [TestMethod]
        public void TestMethod14()
        {
            Assert.IsFalse(ActualTrie.StartsWith("abgg"));
        }

        [TestMethod]
        public void TestMethod15()
        {
            Assert.IsFalse(ActualTrie.StartsWith("abcdgd"));
        }

        [TestMethod]
        public void TestMethod16()
        {
            Assert.IsFalse(ActualTrie.StartsWith("dfc"));
        }

        [TestMethod]
        public void TestMethod17()
        {
            Assert.IsFalse(ActualTrie.StartsWith("lmnp"));
        }

        [TestMethod]
        public void TestMethod18()
        {
            Assert.IsFalse(ActualTrie.StartsWith("cb"));
        }

        [TestMethod]
        public void TestMethod19()
        {
            Assert.IsFalse(ActualTrie.StartsWith("ad"));
        }
    }
}
