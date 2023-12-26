using System;
using System.Collections.Generic;


namespace AlgorithmsDataStructures
{

    public class Stack<T>
    {
        List<T> stack;
        int count;

        public Stack()
        {
            stack = new List<T>();
            count = 0;
        }

        public int Size()
        {
            if (count != 0) return count;

            return 0;
        }

        public T Pop()
        {
            if (count != 0)
            {
                T stackElement = stack[count - 1];
                stack.RemoveAt(count - 1);
                count--;

                return stackElement;
            }
            return default(T);
        }

        public void Push(T val)
        {
            stack.Add(val);
            count++;
        }

        public T Peek()
        {
            if (count != 0) return stack[count - 1];

            return default(T);
        }
    }
}