using System;
using System.Collections.Generic;


namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next;
        public Node(int _value) { value = _value; }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null) head = _item;
            else tail.next = _item;
            tail = _item;
        }

        public int Count()
        {
            Node node = head;
            //Special var for counter value
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }

        public LinkedList SumLists(LinkedList list1, LinkedList list2)
        {
            //Check length Linkedlists
            if (list1.Count() != list2.Count())
            {
                throw new Exception("Length Linkedlists not equal");
            }

            //Creating linkedlist for sum value
            LinkedList sumList = new LinkedList();

            //Setting the initial list node
            Node node1 = list1.head;
            Node node2 = list2.head;

            while (node1 != null && node2 != null)
            {
                //sum value
                int sum = node1.value + node2.value;
                sumList.AddInTail(new Node(sum));

                //Setting the link
                node1 = node1.next;
                node2 = node2.next;
            }

            return sumList;
        }
    }
}