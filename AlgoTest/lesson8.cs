using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class HashTable
    {
        public int size;
        public int step;
        public string[] slots;

        public HashTable(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new string[size];
            for (int i = 0; i < size; i++) slots[i] = null;
        }

        public int HashFun(string value)
        {
            int hashIndex = 0;
            for (int i = 0; i < value.Length; i++)
            {
                hashIndex += Convert.ToInt32(value[i].GetTypeCode());
            }
            return hashIndex % size;
        }

        public int SeekSlot(string value)
        {
            int hashIndex = HashFun(value);
            int originalHashIndex = hashIndex;

            for (int i = 0; i < size; i++)
            {
                if (slots[hashIndex] == null || slots[hashIndex] == value)
                    return hashIndex;

                hashIndex += step;

                if (hashIndex >= size)
                    hashIndex %= size;

                if (hashIndex == originalHashIndex)
                    break;
            }
            return -1;
        }

        public int Put(string value)
        {
            int hashIndex = SeekSlot(value);

            if (hashIndex != -1)
            {
                slots[hashIndex] = value;
                return hashIndex;
            }

            return -1;
        }

        public int Find(string value)
        {
            int hashIndex = SeekSlot(value);

            if (hashIndex != -1 && slots[hashIndex] == value)
                return hashIndex;

            return -1;
        }
    }

}