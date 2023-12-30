using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Queue<T>
    {
        List<T> queue;
        int count;

        public Queue()
        {
            queue = new List<T>();
            count = 0;
        }

        public void Enqueue(T item)
        {
            queue.Add(item);
            count++;
        }

        public T Dequeue()
        {
            if (count != 0)
            {
                T cache = queue[0];
                queue.RemoveAt(0);
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
    }
}