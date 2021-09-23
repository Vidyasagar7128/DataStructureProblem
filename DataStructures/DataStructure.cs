using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DataStructure
    {
        public void Insertion(IComparable[] names)
        {
            int i, j;

            for (i = 1; i < names.Length; i++)
            {
                IComparable data = names[i];
                j = i - 1;
                while ((j >= 0) && (names[j].CompareTo(data) > 0))
                {
                    names[j + 1] = names[j];
                    j--;
                }
                names[j + 1] = data;
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
