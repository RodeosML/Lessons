using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void SumLists_GetTheSumOfValuesOnLinkedLists()
        {
            //Создаем 1 связанный лист и добавляем значения
            LinkedList list1 = new LinkedList();
            list1.AddInTail(new Node(1));
            list1.AddInTail(new Node(2));
            list1.AddInTail(new Node(3));
            //Создаем 2 связанный лист и добавляем значения
            LinkedList list2 = new LinkedList();
            list2.AddInTail(new Node(4));
            list2.AddInTail(new Node(5));
            list2.AddInTail(new Node(6));

            LinkedList sumList = list1.SumLists(list1, list2);

            //Проверяем суммы по узлам листа
            Assert.AreEqual(5, sumList.head.value);
            Assert.AreEqual(7, sumList.head.next.value);
            Assert.AreEqual(9, sumList.tail.value);
            //Конечный узел
            Assert.AreEqual(null, sumList.tail.next);
        }

        [TestMethod]
        public void SumLists_GetTheSumOfNotEqualLengthLinkedLists()
        {
            //Создаем 1 связанный лист и добавляем значения
            LinkedList list1 = new LinkedList();
            list1.AddInTail(new Node(1));
            list1.AddInTail(new Node(2));
            list1.AddInTail(new Node(3));

            //Создаем 2 связанный лист и добавляем значения
            LinkedList list2 = new LinkedList();
            list2.AddInTail(new Node(4));
            list2.AddInTail(new Node(5));

            Assert.ThrowsException<Exception>(() => list1.SumLists(list1, list2));
        }
    }
}
