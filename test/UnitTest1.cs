using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class BloomFilterWithArrayTests
    {
        [TestMethod]
        public void TestAddAndIsValue()
        {
            BloomFilterWithArray filter = new BloomFilterWithArray(32);

            filter.Add("значение1");
            filter.Add("значение2");
            filter.Add("значение3");

            Assert.IsTrue(filter.IsValue("значение1"));
            Assert.IsTrue(filter.IsValue("значение2"));
            Assert.IsTrue(filter.IsValue("значение3"));
        }
    }
}