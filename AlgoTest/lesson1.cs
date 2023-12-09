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

        public Node Find(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) return node;
                node = node.next;
            }
            return null;
        }

        public List<Node> FindAll(int _value)
        {
            //Create an empty list of nodes
            List<Node> nodes = new List<Node>();

            //Set the initial list node
            Node node = head;

            //Cycle to loop through the list and check for values
            while (node != null)
            {
                if (node.value == _value)
                    nodes.Add(node);

                //Setting the link
                node = node.next;
            }
            return nodes;
        }

        public bool Remove(int _value)
        {
            //Checking the empty list
            if (head == null)
                return false;

            //A special case of checking the head of a node for a given value
            if (head.value == _value)
            {
                //Installing a new head node (delete)
                head = head.next;

                //Checking the empty list
                if (head == null) tail = null;
                return true;
            }
            //Cycle to loop through the list and check for value for deletion
            Node node = head;
            while (node.next != null)
            {
                //Set the link to through one node(delete) and check that it is not tail
                if (node.next.value == _value)
                {
                    if (node.next == tail)
                        tail = node;
                    //Setting the link
                    node.next = node.next.next;
                    return true;
                }
                //Setting the link
                node = node.next;
            }
            return false;
        }

        public void RemoveAll(int _value)
        {
            //Checking the empty list
            if (head == null)
                return;

            //A special case of checking the sequence head of a node in list for a given value
            while (head != null && head.value == _value)
            {
                head = head.next;
            }

            Node node = head;
            //Cycle to loop through the list and check for all values for deletion
            while (node != null && node.next != null)
            {
                if (node.next.value == _value)
                {
                    if (node.next == tail) tail = node;
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
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

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            //Checking _nodeAfter is empty and we must need to insert the node at the beginning of the list 
            if (_nodeAfter == null)
            {
                _nodeToInsert.next = head;
                head = _nodeToInsert;
                //checking empty list
                if (tail == null) tail = _nodeToInsert;
            }
            else
            {
                //Insert a node after the specified node
                _nodeToInsert.next = _nodeAfter.next;
                _nodeAfter.next = _nodeToInsert;
                //Сhecking for the last node in the list
                if (_nodeAfter == tail) tail = _nodeToInsert;
            }
        }
    }
}