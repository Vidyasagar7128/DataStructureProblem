using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DataStructure
    {
        public int FindWord(string[] words, string str)
        {
            int start = 0;
            int end = words.Length - 1;
            while (start <= end)
            {
                int mid = start + end / 2;
                int result = str.CompareTo(words[mid]);
                if (result == 0)
                {
                    return mid;
                }
                if (result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
