using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;
using AlgoDataStructures.AlgoPart1;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class NativeCacheTests
    {
        [TestMethod]
        public void TestPut()
        {
            NativeCache<int> cache = new NativeCache<int>(5);
            cache.Put("key1", 1);
            cache.Put("key2", 2);
            cache.Put("key3", 3);
            cache.Put("key4", 4);
            cache.Put("key5", 5);


            Assert.AreEqual(1, cache.Get("key1"));
            Assert.AreEqual(2, cache.Get("key2"));
            Assert.AreEqual(3, cache.Get("key3"));
            Assert.AreEqual(4, cache.Get("key4"));
            Assert.AreEqual(5, cache.Get("key5"));

            cache.Put("key6", 6);

            Assert.AreNotEqual(1, cache.Get("key1")); //Displaced 
            Assert.AreEqual(2, cache.Get("key2"));
            Assert.AreEqual(3, cache.Get("key3"));
            Assert.AreEqual(4, cache.Get("key4"));
            Assert.AreEqual(5, cache.Get("key5"));
            Assert.AreEqual(6, cache.Get("key6"));
        }
    }
}