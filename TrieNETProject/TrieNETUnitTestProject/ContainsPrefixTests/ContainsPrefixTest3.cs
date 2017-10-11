using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieNETProject;

namespace TrieNETUnitTestProject
{
    [TestClass]
    public class ContainsPrefixTest3
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
            Assert.IsTrue(ActualTrie.ContainsPrefix("a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("c"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("l"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("ab"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("abc"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("abcd"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("abg"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("abgl"));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("cd"));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("cdf"));
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("lm"));
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.IsTrue(ActualTrie.ContainsPrefix("lmn"));
        }

        [TestMethod]
        public void TestMethod13()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("abd"));
        }

        [TestMethod]
        public void TestMethod14()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("abgg"));
        }

        [TestMethod]
        public void TestMethod15()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("abcdgd"));
        }

        [TestMethod]
        public void TestMethod16()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("dfc"));
        }

        [TestMethod]
        public void TestMethod17()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("lmnp"));
        }

        [TestMethod]
        public void TestMethod18()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("cb"));
        }

        [TestMethod]
        public void TestMethod19()
        {
            Assert.IsFalse(ActualTrie.ContainsPrefix("ad"));
        }
    }
}
