using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class BloomFilterTests
    {
        [TestMethod]
        public void TestAdd()
        {
            BloomFilter filter = new BloomFilter(10);
            filter.Add("0123456789");
            filter.Add("1234567890");
            filter.Add("2345678901");
            filter.Add("3456789012");
            filter.Add("4567890123");
            filter.Add("5678901234");
            filter.Add("6789012345");
            filter.Add("7890123456");
            filter.Add("8901234567");
            filter.Add("9012345678");

            Assert.AreEqual(10, filter.filter_len);
        }

        [TestMethod]
        public void TestIsValue()
        {
            BloomFilter filter = new BloomFilter(10);
            filter.Add("0123456789");
            filter.Add("1234567890");
            filter.Add("2345678901");
            filter.Add("3456789012");
            filter.Add("4567890123");
            filter.Add("5678901234");
            filter.Add("6789012345");
            filter.Add("7890123456");
            filter.Add("8901234567");
            filter.Add("9012345678");

            Assert.IsTrue(filter.IsValue("0123456789"));
            Assert.IsTrue(filter.IsValue("1234567890"));
            Assert.IsTrue(filter.IsValue("2345678901"));
            Assert.IsTrue(filter.IsValue("3456789012"));
            Assert.IsTrue(filter.IsValue("4567890123"));
            Assert.IsTrue(filter.IsValue("5678901234"));
            Assert.IsTrue(filter.IsValue("6789012345"));
            Assert.IsTrue(filter.IsValue("7890123456"));
            Assert.IsTrue(filter.IsValue("8901234567"));
            Assert.IsTrue(filter.IsValue("9012345678"));
        }

    }
}