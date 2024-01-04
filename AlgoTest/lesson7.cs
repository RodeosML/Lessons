using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node<T>
    {
        public T value;
        public Node<T> next, prev;

        public Node(T _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class OrderedList<T>
    {
        public Node<T> head, tail;
        private bool _ascending;

        public OrderedList(bool asc)
        {
            head = null;
            tail = null;
            _ascending = asc;
        }

        public int Compare(T v1, T v2)
        {
            int result = 0;
            if (typeof(T) == typeof(String))
            {
                //Lexical comparison
                string comparableV1 = v1.ToString().Trim();
                string comparableV2 = v2.ToString().Trim();
                result = comparableV1.CompareTo(comparableV2) == 1 ?
                    1 : comparableV1.CompareTo(comparableV2) == 0 ?
                    0 : -1;
            }
            else
            {
                //Arithmetic comparison
                result = Convert.ToInt32(v1) == Convert.ToInt32(v2) ?
                    0 : Convert.ToInt32(v1) > Convert.ToInt32(v2) ?
                    1 : -1;
            }

            return result;
        }

        public void Add(T value)
        {
            Node<T> _insertValue = new Node<T>(value);
            Node<T> node = head;

            if (head == tail && head == null)
            {
                head = _insertValue;
                tail = _insertValue;
                return;
            }

            if (node == head &&
                ((Compare(node.value, value) != -1 && _ascending == true) ||
                (Compare(node.value, value) != 1 && _ascending == false)))
            {
                head = _insertValue;
                _insertValue.next = node;
                node.prev = _insertValue;
                return;
            }

            while (node != null)
            {
                if ((Compare(node.value, value) != 1 && _ascending == false) ||
                    (Compare(node.value, value) != -1 && _ascending == true))
                {
                    node.prev.next = _insertValue;
                    _insertValue.prev = node.prev;
                    _insertValue.next = node;
                    node.prev = _insertValue;
                    return;
                }

                else if (node == tail &&
                    ((Compare(node.value, value) != 1 && _ascending == true) ||
                    (Compare(node.value, value) != -1 && _ascending == false)))
                {
                    tail = _insertValue;
                    _insertValue.prev = node;
                    node.next = _insertValue;
                    return;
                }
                node = node.next;
            }
        }

        public Node<T> Find(T val)
        {
            Node<T> node = head;
            while (node != null)
            {
                if (Compare(node.value, val) == 0)
                {
                    return node;
                }

                if (Compare(node.value, val) == 1 && _ascending == true)
                {
                    break;
                }

                if (Compare(node.value, val) == -1 && _ascending == false)
                {
                    break;
                }
                node = node.next;
            }
            return null;
        }

        public void Delete(T val)
        {
            Node<T> node = head;
            while (node != null)
            {
                if (node == head && node == tail && Compare(node.value, val) == 0)
                {
                    head = null;
                    tail = null;
                    return;
                }
                else if (node == head && Compare(node.value, val) == 0)
                {
                    node.next.prev = null;
                    head = node.next;
                    return;
                }
                else if (node == tail && Compare(node.value, val) == 0)
                {
                    node.prev.next = null;
                    tail = node.prev;
                    return;
                }
                else if (Compare(node.value, val) == 0)
                {
                    node.prev.next = node.next;
                    node.next.prev = node.prev;
                    return;
                }
                node = node.next;
            }
        }

        public void Clear(bool asc)
        {
            _ascending = asc;
            head = null;
            tail = null;
        }

        public int Count()
        {
            int count = 0;
            Node<T> node = head;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }

        List<Node<T>> GetAll()
        {
            List<Node<T>> r = new List<Node<T>>();
            Node<T> node = head;
            while (node != null)
            {
                r.Add(node);
                node = node.next;
            }
            return r;
        }
    }

}