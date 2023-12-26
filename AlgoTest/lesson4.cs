using System;
using System.Collections.Generic;


namespace AlgorithmsDataStructures
{

    public class Stack<T>
    {
        LinkedList<T> stackPattern;
        int countElements;

        public Stack()
        {
            stackPattern = new LinkedList<T>();
            countElements = 0;
        }

        public int Size()
        {
            return countElements;
        }

        public T Pop()
        {
            if (countElements != 0)
            {
                T stackElement = stackPattern.First.Value;
                stackPattern.RemoveFirst();
                countElements--;

                return stackElement;
            }
            return default(T);
        }

        public void Push(T val)
        {
            stackPattern.AddFirst(val);
            countElements++;
        }

        public T Peek()
        {
            if (countElements != 0) return stackPattern.First.Value;

            return default(T);
        }
    }
}