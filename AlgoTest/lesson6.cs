using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Deque<T>
    {
        List<T> deque;
        int count;

        public Deque()
        {
            deque = new List<T>();
            count = 0;
        }

        public void AddFront(T item)
        {
            deque.Insert(0, item);
            count++;
        }

        public void AddTail(T item)
        {
            deque.Add(item);
            count++;
        }

        public T RemoveFront()
        {
            T cache;
            if (count != 0)
            {
                cache = deque[0];
                deque.RemoveAt(0);
                count--;
                return cache;
            }
            return default(T);
        }

        public T RemoveTail()
        {
            T cache;
            if (count != 0)
            {
                cache = deque[count - 1];
                deque.RemoveAt(count - 1);
                count--;
                return cache;
            }
            return default(T);
        }

        public int Size()
        {
            if (count != 0) return count;
            return 0;
        }

        public string CheckPolyndrom(string _value)
        {
            Deque<char> dequeForChar = new Deque<char>();

            foreach (char c in _value)
            {
                dequeForChar.AddFront(c);
            }

            while (dequeForChar.count > 1)
            {
                if (dequeForChar.RemoveFront() != dequeForChar.RemoveTail())
                {
                    return "Not a polyndrom";
                }
            }
            return "Polyndrom";
        }
    }

}