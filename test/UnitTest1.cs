using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class PowerSetTests
    {
        [TestMethod]
        public void ReturnCorrectSize()
        {
            PowerSet<string> powerSet = new PowerSet<string>();

            int size = powerSet.Size();
            Assert.AreEqual(0, size);
        }

        [TestMethod]
        public void ReturnTrueIfValueExist()
        {
            PowerSet<string> powerSet = new PowerSet<string>();
            powerSet.Put("проверка");

            bool result = powerSet.Get("проверка");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddDuplicateElement()
        {
            var powerSet = new PowerSet<int>();
            powerSet.Put(10);

            powerSet.Put(10);

            Assert.AreEqual(1, powerSet.Size());
        }


        [TestMethod]
        public void ReturnFalseIfValueNotExist()
        {
            PowerSet<string> powerSet = new PowerSet<string>();

            bool result = powerSet.Get("проверка");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RemoveValuePowerSet()
        {
            PowerSet<string> powerSet = new PowerSet<string>();
            powerSet.Put("проверка");

            bool result = powerSet.Remove("проверка");

            Assert.IsFalse(powerSet.Get("проверка"));
        }

        [TestMethod]
        public void IntersectionReturnEmptySetWhenNoCommonElement()
        {
            var powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");
            powerSet1.Put("проверка_3");

            var powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_4");
            powerSet2.Put("проверка_5");
            powerSet2.Put("проверка_6");

            var intersected = powerSet1.Intersection(powerSet2);

            Assert.AreEqual(0, intersected.Size());
        }

        [TestMethod]
        public void IntersectionReturnNonEmptyWhenCommonElementsExist()
        {
            var powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");
            powerSet1.Put("проверка_4");

            var powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_4");
            powerSet2.Put("проверка_5");
            powerSet2.Put("проверка_6");

            var intersected = powerSet1.Intersection(powerSet2);

            Assert.AreEqual(1, intersected.Size());
            Assert.IsTrue(intersected.Get("проверка_4"));
        }

        [TestMethod]
        public void CheckUnionReturnUnionOfTwoPowerSet()
        {
            PowerSet<string> powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");

            PowerSet<string> powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_2");
            powerSet2.Put("проверка_3");

            PowerSet<string> result = powerSet1.Union(powerSet2);

            Assert.IsTrue(result.Get("проверка_1"));
            Assert.IsTrue(result.Get("проверка_2"));
            Assert.IsTrue(result.Get("проверка_3"));
            Assert.AreEqual(3, result.Size());
        }

        [TestMethod]
        public void CheckUnionReturnSetEqualToNonEmptySetWhenOneSetIsEmpty()
        {
            var powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");

            var powerSet2 = new PowerSet<string>();

            var united = powerSet1.Union(powerSet2);

            Assert.AreEqual(2, united.Size());
            Assert.IsTrue(united.Get("проверка_1"));
            Assert.IsTrue(united.Get("проверка_2"));
        }

        [TestMethod]
        public void DifferenceReturnEmptySetWhenSetsHaveNoCommonElements()
        {
            PowerSet<string> powerSet1 = new PowerSet<string>();

            PowerSet<string> powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_3");
            powerSet2.Put("проверка_4");

            var result = powerSet1.Difference(powerSet2);

            Assert.AreEqual(0, result.Size());
        }

        [TestMethod]
        public void ReturnDifferenceOfTwoPowerSet()
        {
            PowerSet<string> powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");
            powerSet1.Put("проверка_3");

            PowerSet<string> powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_2");
            powerSet2.Put("проверка_3");

            PowerSet<string> result = powerSet1.Difference(powerSet2);

            Assert.IsTrue(result.Get("проверка_1"));
            Assert.IsFalse(result.Get("проверка_2"));
            Assert.IsFalse(result.Get("проверка_3"));
            Assert.AreEqual(1, result.Size());
        }

        [TestMethod]
        public void ReturnTrueIfPowerSetIsSubsetOfAnotherPowerSet()
        {
            PowerSet<string> powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");
            powerSet1.Put("проверка_3");

            PowerSet<string> powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_1");
            powerSet2.Put("проверка_2");

            bool result = powerSet1.IsSubset(powerSet2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnFalseIfPowerSetIsNotSubsetOfAnotherPowerSet()
        {
            PowerSet<string> powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");
            powerSet1.Put("проверка_3");

            PowerSet<string> powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_1");
            powerSet2.Put("проверка_4");

            bool result = powerSet1.IsSubset(powerSet2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnTrueWhenAllElementsOfParameterAreInCurrentSet()
        {
            PowerSet<string> powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");
            powerSet1.Put("проверка_3");
            powerSet1.Put("проверка_4");

            PowerSet<string> powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_1");
            powerSet2.Put("проверка_2");
            powerSet2.Put("проверка_3");
            powerSet2.Put("проверка_4");

            bool result = powerSet2.IsSubset(powerSet1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("Performance")]
        public void PerformanceTest()
        {
            PowerSet<string> powerSet1 = new PowerSet<string>();
            PowerSet<string> powerSet2 = new PowerSet<string>();

            Stopwatch stopwatch = Stopwatch.StartNew();
            PowerSet<string> result = powerSet1.Intersection(powerSet2);
            stopwatch.Stop();

            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 2000);
        }

    }
}