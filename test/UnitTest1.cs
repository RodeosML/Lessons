using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class NativeDictionaryTests
    {
        [TestMethod]
        public void ShouldPutNewKeyAddValueToDictionary()
        {
            NativeDictionary<int> dictionary = new NativeDictionary<int>(10);

            dictionary.Put("первое значение", 1);

            Assert.AreEqual(1, dictionary.Get("первое значение"));
        }

        [TestMethod]
        public void ShouldPutExistingKeyWithUpdateValueInDictionary()
        {
            NativeDictionary<int> dictionary = new NativeDictionary<int>(10);
            dictionary.Put("первое значение", 1);

            dictionary.Put("первое значение", 2);

            Assert.AreEqual(2, dictionary.Get("первое значение"));
        }

        [TestMethod]
        public void ShouldCheckKeyReturnTrue()
        {
            NativeDictionary<int> dictionary = new NativeDictionary<int>(10);
            dictionary.Put("первое значение", 1);

            bool isKeyPresent = dictionary.IsKey("первое значение");

            Assert.IsTrue(isKeyPresent);
        }

        [TestMethod]
        public void ShoulAbsentKeyReturnFalse()
        {
            NativeDictionary<int> dictionary = new NativeDictionary<int>(10);
            dictionary.Put("первое значение", 1);

            bool isKeyPresent = dictionary.IsKey("второе значение");

            Assert.IsFalse(isKeyPresent);
        }

        [TestMethod]
        public void ShouldGetPresentKeyReturnValue()
        {
            NativeDictionary<int> dictionary = new NativeDictionary<int>(10);
            dictionary.Put("первое значение", 1);

            int value = dictionary.Get("первое значение");

            Assert.AreEqual(1, value);
        }

        [TestMethod]
        public void ShouldGetAbsentKeyReturnDefaultValue()
        {
            NativeDictionary<int> dictionary = new NativeDictionary<int>(10);
            dictionary.Put("первое значение", 1);

            int value = dictionary.Get("второе значение");

            Assert.AreEqual(default(int), value);
        }
    }

}