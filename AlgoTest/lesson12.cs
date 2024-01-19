using System;
using System.Collections.Generic;

namespace AlgoDataStructures.AlgoPart1
{

    public class NativeCache<T>
    {
        public int size;
        public string[] slots;
        public T[] values;
        public int[] hits;

        private int len;

        public NativeCache(int length)
        {
            slots = new string[length];
            values = new T[length];
            hits = new int[length];
            size = 0;
            len = length;
        }

        private int Hash(string key)
        {
            int result = 0;
            for (int i = 0; i < key.Length; i++)
            {
                int code = (int)key[i];
                result = Math.Abs(result * 223 + code);
            }
            return result;
        }

        public int SeekSlot(string key)
        {
            int index = Hash(key) % len;

            string element = slots[index];
            if (element != null && !key.Equals(element))
            {
                return GetEmptyOrOldestSlot(index);
            }

            return index;
        }

        private int GetEmptyOrOldestSlot(int start)
        {
            int length = slots.Length;
            if (size == length)
                return FindTheOldestValue();
            for (int i = start; ; i++)
            {
                if (i >= length)
                    i = 0;

                if (slots[i] != null)
                    return i;
            }
        }

        private int FindTheOldestValue()
        {
            int index = 0;
            int min = int.MaxValue;
            int length = hits.Length;
            for (int i = 0; i < length; i++)
            {
                if (hits[i] < min)
                {
                    index = i;
                    min = hits[i];
                }
            }
            return index;
        }

        public void Put(string key, T val)
        {
            int slot = 0;

            if (size == slots.Length)
                slot = FindTheOldestValue();

            if (size != slots.Length)
                slot = SeekSlot(key);

            if (slots[slot] == null)
                size++;

            slots[slot] = key;
            values[slot] = val;
            hits[slot] = 0;
        }

        public T Get(string key)
        {
            if (key == null)
                return default(T);

            int index = Hash(key) % slots.Length;

            if (key == slots[index])
            {
                hits[index]++;
                return values[index];
            }

            int length = slots.Length;
            int step = 2;

            for (int i = index; step != 0; i += step)
            {
                if (i >= length)
                {
                    step--;
                    i = 0;
                }

                if (key == slots[i])
                {
                    hits[i]++;
                    return values[i];
                }
            }

            return default(T);
        }
    }
}