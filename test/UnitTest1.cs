using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class OrderedList
    {
        [TestMethod]
        public void ShouldReturnCorrectNodeWhenValueExist()
        {
            OrderedList<int> list = new OrderedList<int>(true);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Node<int> result = list.Find(2);

            Assert.AreEqual(2, result.value);
        }

        [TestMethod]
        public void ShouldReturNullWhenValueDoesNotExist()
        {
            OrderedList<int> list = new OrderedList<int>(true);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Node<int> result = list.Find(4);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void ShouldAddValueInCorrectOrderUseAscending()
        {
            OrderedList<int> list = new OrderedList<int>(true);
            list.Add(2);
            list.Add(1);
            list.Add(3);

            Node<int> node1 = list.head;
            Node<int> node2 = node1.next;
            Node<int> node3 = node2.next;

            Assert.AreEqual(1, node1.value);
            Assert.AreEqual(2, node2.value);
            Assert.AreEqual(3, node3.value);
        }

        [TestMethod]
        public void ShouldAddValueInCorrectOrderUseDescending()
        {
            OrderedList<int> list = new OrderedList<int>(false);
            list.Add(2);
            list.Add(1);
            list.Add(3);

            Node<int> node1 = list.head;
            Node<int> node2 = node1.next;
            Node<int> node3 = node2.next;

            Assert.AreEqual(3, node1.value);
            Assert.AreEqual(2, node2.value);
            Assert.AreEqual(1, node3.value);
        }
    }
}
