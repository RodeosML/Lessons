using System.Collections.Generic;
using System;
using System.IO;

namespace AlgorithmsDataStructures
{
    public class BloomFilterWithArray
    {
        public int filter_len;
        public int[] BitArray;

        public BloomFilterWithArray(int f_len)
        {
            filter_len = f_len;
            int len = (int)Math.Ceiling(f_len / 32.0);
            BitArray = new int[len];
        }

        public int Hash1(string str1)
        {
            int result = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                int code = (int)str1[i];
                result = Math.Abs(result * 17 + code) % filter_len;
            }
            return 1 << result;
        }
        public int Hash2(string str1)
        {
            int result = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                int code = (int)str1[i];
                result = Math.Abs(result * 223 + code) % filter_len;
            }
            return 1 << result;
        }

        public void Add(string str1)
        {
            int pos1 = Hash1(str1) % filter_len;
            int pos2 = Hash2(str1) % filter_len;

            BitArray[pos1 / 32] |= 1 << (pos1 % 32);
            BitArray[pos2 / 32] |= 1 << (pos2 % 32);
        }

        public bool IsValue(string str1)
        {
            int pos1 = Hash1(str1) % filter_len;
            int pos2 = Hash2(str1) % filter_len;
            int result = BitArray[pos1 / 32] | BitArray[pos2 / 32];

            return ((BitArray[pos1 / 32] | BitArray[pos2 / 32]) & result) == result;
        }
    }
}