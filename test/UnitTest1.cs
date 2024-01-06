using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class HashCodeTests
    {
        [TestMethod]
        public void TestHashCode()
        {
            HashTable hash = new HashTable(19, 3);
            string value = "test";

            int actualHashCode = hash.HashFun(value);

            Assert.IsTrue(actualHashCode >= 0 && actualHashCode < hash.size);
        }

        [TestMethod]
        public void ShouldReturnCorrectIndexWithCollision()
        {
            HashTable hashTable = new HashTable(19, 3);
            string value1 = "тест с коллизей";
            string value2 = "коллизия";

            int index1 = hashTable.SeekSlot(value1);
            hashTable.slots[index1] = value2;
            int index2 = hashTable.SeekSlot(value2);

            Assert.AreNotEqual(index1, index2);
        }

        [TestMethod]
        public void ShouldAddValueToHashTable()
        {
            HashTable hashTable = new HashTable(19, 3);
            string value = "Проверка";

            int index = hashTable.Put(value);

            Assert.AreEqual(hashTable.slots[index], value);
        }

        [TestMethod]
        public void ShouldReturnCorrectIndexWithExistingValue()
        {
            HashTable hashTable = new HashTable(19, 3);
            string value = "Проверка";

            int index = hashTable.Put(value);

            int foundIndex = hashTable.Find(value);

            Assert.AreEqual(index, foundIndex);
        }

        [TestMethod]
        public void ShouldReturnNegativeIndexWithNonExistingValue()
        {
            HashTable hashTable = new HashTable(19, 3);
            string value = "Проверка";

            hashTable.Put("Находки");

            int foundIndex = hashTable.Find(value);

            Assert.AreEqual(-1, foundIndex);
        }

    }
}