using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next, prev;

        public Node(int _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class LinkedList2
    {
        public Node head;
        public Node tail;

        public LinkedList2()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null)
            {
                head = _item;
                head.next = null;
                head.prev = null;
            }
            else
            {
                tail.next = _item;
                _item.prev = tail;
            }
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
                if (node.value == _value) nodes.Add(node);

                //Setting the link
                node = node.next;
            }
            return nodes;
        }

        public bool Remove(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value)
                {
                    //Checking unique node
                    if (node == head && node == tail)
                    {
                        head = null;
                        tail = null;
                    }
                    //Сhecking head node
                    else if (node == head)
                    {
                        node.next.prev = null;
                        head = node.next;
                    }
                    //Checking tail node
                    else if (node == tail)
                    {
                        node.prev.next = null;
                        tail = node.prev;
                    }
                    else
                    {
                        node.prev.next = node.next;
                        node.next.prev = node.prev;
                    }
                    return true;
                }
                //Setting the link
                node = node.next;
            }
            return false;
        }

        public void RemoveAll(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value)
                {
                    //Сhecking unique node
                    if (node == head && node == tail)
                    {
                        head = null;
                        tail = null;
                        return;
                    }
                    //Сhecking head node
                    if (node == head)
                    {
                        node.next.prev = null;
                        head = node.next;
                    }
                    //Checking tail node
                    if (node == tail)
                    {
                        node.prev.next = null;
                        tail = node.prev;
                    }
                    else
                    {
                        //Remove use two links
                        node.prev.next = node.next;
                        node.next.prev = node.prev;
                    }
                }
                //Setting the link (step next)
                node = node.next;
            }
            return;
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
            Node node = head;
            while (node != null)
            {
                if (_nodeAfter == null)
                {
                    node.prev = _nodeToInsert;
                    _nodeToInsert.next = node;
                    head = _nodeToInsert;
                    return;
                }
                //Checking last node list
                if (node == _nodeAfter && node == tail)
                {
                    node.next = _nodeToInsert;
                    _nodeToInsert.prev = node;
                    tail = _nodeToInsert;
                    return;
                }
                //Checking should we add new node after the current node 
                if (node == _nodeAfter)
                {
                    _nodeToInsert.next = node.next;
                    node.next.prev = _nodeToInsert;
                    node.next = _nodeToInsert;
                    _nodeToInsert.prev = node;
                    return;
                }
                node = node.next;
            }
            //Checking first element on list
            if (_nodeAfter == null)
            {
                head = _nodeToInsert;
                tail = _nodeToInsert;
                return;
            }

        }

    }
}