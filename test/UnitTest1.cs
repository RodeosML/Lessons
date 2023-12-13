using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Find_MustReturnNodeWithMatchingValue()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);


            var result = list.Find(2);

            //Проверяем утверждение
            Assert.AreEqual(node2, result);
        }

        [TestMethod]
        public void Find_MustReturnNullIfNoMatchingValue()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);

            var result = list.Find(4);

            //Проверяем утверждение
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FindAll_MustReturnListOfNodesWithMatchingValue()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(2);
            var node4 = new Node(3);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);
            list.AddInTail(node4);

            var result = list.FindAll(2);

            //Проверяем утверждение
            CollectionAssert.AreEqual(new List<Node>
            { node2, node3 }, result);
        }

        [TestMethod]
        public void FindAll_MustReturnEmptyListIfNoMatchingValue()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);

            var result = list.FindAll(4);

            //Проверяем утверждение
            CollectionAssert.AreEqual(new List<Node>(), result);
        }

        [TestMethod]
        public void Remove_MustReturnFalseIfNoMatchingValue()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);

            var result = list.Remove(4);

            //Проверяем целостность списка
            Assert.IsFalse(result);
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node3, list.tail);
            Assert.AreEqual(node3, node2.next);
        }

        [TestMethod]
        public void Remove_MustRemoveNodeWithMatchingValue()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);
            list.AddInTail(node4);

            var result = list.Remove(2);

            //Проверяем утверждение
            Assert.IsTrue(result);
            //Проверяем целостность списка
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node4, list.tail);
            Assert.AreEqual(node3, list.tail.prev);

            var result2 = list.Remove(1);

            //Проверяем утверждение
            Assert.IsTrue(result2);
            //Проверяем целостность списка
            Assert.AreEqual(null, list.head.prev);
            Assert.AreEqual(null, list.tail.next);
            Assert.AreEqual(null, list.tail.prev.prev);
            Assert.AreEqual(null, list.tail.next);
            Assert.AreEqual(node4, list.head.next);

            var result3 = list.Remove(3);

            //Проверяем утверждение
            Assert.IsTrue(result3);
            //Проверяем целостность списка
            Assert.AreEqual(null, list.head.prev);
            Assert.AreEqual(null, list.tail.next);
            Assert.AreEqual(null, list.tail.prev);
            Assert.AreEqual(null, list.tail.next);
            Assert.AreEqual(node4, list.head);
        }

        [TestMethod]
        public void RemoveAll_MustRemoveAllNodesWithMatchingValue()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(2);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);
            list.AddInTail(node4);

            list.RemoveAll(2);

            ///Проверяем целостность списка
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node3, list.tail);
            Assert.AreEqual(null, list.tail.next);
            Assert.AreEqual(node3, list.head.next);
            Assert.AreEqual(node1, list.tail.prev);
        }

        [TestMethod]
        public void Clear_MustRemoveAllNodesFromList()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);

            list.Clear();

            //Проверяем что список пуст
            Assert.IsNull(list.head);
            Assert.IsNull(list.tail);
        }

        [TestMethod]
        public void Count_MustReturnNumberOfNodesInList()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(18);
            var node2 = new Node(25);
            var node3 = new Node(45);
            var node4 = new Node(40);
            var node5 = new Node(50);
            list.AddInTail(node1);
            list.AddInTail(node2);
            list.AddInTail(node3);
            list.AddInTail(node4);
            list.AddInTail(node5);

            var result = list.Count();

            //Корректен ли расчет количества
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void InsertAfter_MustInsertNodeAfterGivenNode()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            list.AddInTail(node1);
            list.AddInTail(node3);

            list.InsertAfter(node1, node2);

            //Проверяем последовательность
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node3, list.tail);
            Assert.AreEqual(node2, node1.next);
        }

        [TestMethod]
        public void InsertAfter_MustInsertANodeAtTheBeginningOfTheListIfTheGiveNodeIsNull()
        {
            //Создаем экемпляр класса и заполняем его
            var list = new LinkedList2();
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            list.AddInTail(node2);
            list.AddInTail(node3);

            //null + список
            list.InsertAfter(null, node1);

            //Проверяем последовательность
            Assert.AreEqual(node1, list.head);
            Assert.AreEqual(node3, list.tail);
            Assert.AreEqual(node2, node1.next);
        }

    }
}
