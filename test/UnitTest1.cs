using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class PowerSetTests
    {
        [TestMethod]
        public void Size_ReturnsCorrectSize()
        {
            PowerSet<string> powerSet = new PowerSet<string>();

            int size = powerSet.Size();
            Assert.AreEqual(0, size);
        }

        [TestMethod]
        public void Put_AddsValueToPowerSet()
        {
            PowerSet<string> powerSet = new PowerSet<string>();

            powerSet.Put("проверка");

            Assert.IsTrue(powerSet.Get("проверка"));
        }

        [TestMethod]
        public void Get_ReturnsTrueIfзначениеExists()
        {
            PowerSet<string> powerSet = new PowerSet<string>();
            powerSet.Put("проверка");

            bool result = powerSet.Get("проверка");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Get_ReturnsFalseIfValueDoesNotExist()
        {
            PowerSet<string> powerSet = new PowerSet<string>();

            bool result = powerSet.Get("проверка");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Remove_RemovesValueFromPowerSet()
        {
            PowerSet<string> powerSet = new PowerSet<string>();
            powerSet.Put("проверка");

            bool result = powerSet.Remove("проверка");

            Assert.IsFalse(powerSet.Get("проверка"));
        }

        [TestMethod]
        public void Remove_ReturnsFalseIfValueDoesNotExist()
        {
            PowerSet<string> powerSet = new PowerSet<string>();

            bool result = powerSet.Remove("проверка");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Intersection_ReturnsIntersectionOfTwoPowerSets()
        {
            PowerSet<string> powerSet1 = new PowerSet<string>();
            powerSet1.Put("проверка_1");
            powerSet1.Put("проверка_2");
            powerSet1.Put("проверка_3");

            PowerSet<string> powerSet2 = new PowerSet<string>();
            powerSet2.Put("проверка_2");
            powerSet2.Put("проверка_3");
            powerSet2.Put("проверка_5");

            PowerSet<string> result = powerSet1.Intersection(powerSet2);

            Assert.IsTrue(result.Get("проверка_2"));
            Assert.IsTrue(result.Get("проверка_3"));
            Assert.AreEqual(2, result.Size());
        }

        [TestMethod]
        public void Union_ReturnsUnionOfTwoPowerSets()
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
        public void Difference_ReturnsDifferenceOfTwoPowerSets()
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
        public void IsSubset_ReturnsTrueIfPowerSetIsSubsetOfAnotherPowerSet()
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
        public void IsSubset_ReturnsFalseIfPowerSetIsNotSubsetOfAnotherPowerSet()
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
    }
}