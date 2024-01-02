using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class Deque
    {
        [TestMethod]
        public void ShouldAddItemsFrontOfDeque()
        {
            Deque<int> deque = new Deque<int>();

            deque.AddFront(1);
            deque.AddFront(2);
            deque.AddFront(3);

            //Removing all
            Assert.AreEqual(3, deque.RemoveFront());
            Assert.AreEqual(2, deque.RemoveFront());
            Assert.AreEqual(1, deque.RemoveFront());

            //Checking size
            Assert.AreEqual(0, deque.Size());
        }

        [TestMethod]
        public void ShouldAddItemsTailOfDeque()
        {
            Deque<int> deque = new Deque<int>();

            deque.AddTail(1);
            deque.AddTail(2);
            deque.AddTail(3);

            //Removing all
            Assert.AreEqual(1, deque.RemoveFront());
            Assert.AreEqual(2, deque.RemoveFront());
            Assert.AreEqual(3, deque.RemoveFront());

            //Checking size
            Assert.AreEqual(0, deque.Size());
        }

        [TestMethod]
        public void ShouldRemoveItemsFrontOfDeque()
        {
            Deque<int> deque = new Deque<int>();

            deque.AddFront(1);
            deque.AddFront(2);
            deque.AddFront(3);

            //Removing all
            Assert.AreEqual(3, deque.RemoveFront());
            Assert.AreEqual(2, deque.RemoveFront());
            Assert.AreEqual(1, deque.RemoveFront());

            //Checking size
            Assert.AreEqual(0, deque.Size());
        }

        [TestMethod]
        public void ShouldRemoveItemsTailOfDeque()
        {
            Deque<int> deque = new Deque<int>();

            deque.AddTail(1);
            deque.AddTail(2);
            deque.AddTail(3);

            //Removing all
            Assert.AreEqual(3, deque.RemoveTail());
            Assert.AreEqual(2, deque.RemoveTail());
            Assert.AreEqual(1, deque.RemoveTail());

            //Checking size
            Assert.AreEqual(0, deque.Size());
        }

        [TestMethod]
        public void ShouldCorrectSizeItemsOfDeque()
        {
            Deque<int> deque = new Deque<int>();

            deque.AddFront(1);
            deque.AddFront(2);
            deque.AddFront(3);
            deque.AddFront(4);

            Assert.AreEqual(4, deque.Size());
        }

        [TestMethod]
        public void ShouldPolyndromOfDeque()
        {
            Deque<string> deque = new Deque<string>();

            Assert.AreEqual("Polyndrom", deque.CheckPolyndrom("довод"));
            Assert.AreEqual("Nepolyndrom", deque.CheckPolyndrom("тапок"));
        }
    }
}
