using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class NativeDictionary<T>
    {
        public int size;
        public string[] slots;
        public T[] values;

        public NativeDictionary(int sz)
        {
            size = sz;
            slots = new string[size];
            values = new T[size];
        }

        public int HashFun(string key)
        {
            int hashIndex = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hashIndex += Convert.ToInt32(key[i].GetTypeCode());
            }
            return hashIndex % size;
        }

        public bool IsKey(string key)
        {
            if (slots[HashFun(key)] == key) return true;
            return false;
        }

        public void Put(string key, T value)
        {
            slots[HashFun(key)] = key;
            values[HashFun(key)] = value;
        }

        public T Get(string key)
        {
            if (IsKey(key)) return values[HashFun(key)];
            return default(T);
        }
    }
}