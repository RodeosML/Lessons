using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class PowerSet<T>
    {
        public int capacity;
        public List<T> slots;

        public PowerSet()
        {
            slots = new List<T>();
            capacity = 0;
        }

        public int Size()
        {
            return capacity;
        }

        public void Put(T value)
        {
            if (!Get(value))
            {
                slots.Add(value);
                capacity++;
            }
        }

        public bool Get(T value)
        {
            return slots.Contains(value);
        }

        public bool Remove(T value)
        {
            if (Get(value))
            {
                slots.Remove(value);
                capacity--;
                return true;
            }
            return false;
        }

        public PowerSet<T> Intersection(PowerSet<T> set2)
        {
            PowerSet<T> intersected = new PowerSet<T>();
            foreach (T item in slots)
            {
                if (set2.Get(item))
                {
                    intersected.Put(item);
                }
            }
            return intersected;
        }

        public PowerSet<T> Union(PowerSet<T> set2)
        {
            PowerSet<T> united = new PowerSet<T>();
            foreach (var item in slots)
            {
                united.Put(item);
            }

            foreach (var item in set2.slots)
            {
                united.Put(item);
            }

            return united;
        }

        public PowerSet<T> Difference(PowerSet<T> set2)
        {
            PowerSet<T> differed = new PowerSet<T>();
            foreach (T item in slots)
            {
                differed.Put(item);
            }

            foreach (T item in set2.slots)
            {
                differed.Remove(item);
            }
            
            return differed;
        }

        public bool IsSubset(PowerSet<T> set2)
        {
            if (slots.Count < set2.Size())
            {
                return false;
            }

            foreach (T item in set2.slots)
            {
                if (!slots.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}