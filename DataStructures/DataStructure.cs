using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DataStructures
{
    class DataStructure<Gtype>
    {
        public void Prime()
        {
            List<int> primes = new List<int>();
            int count = 0;
            for (int i = 0; i <= 1000; i++)
            {
                int flag = 0;
                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    primes.Add(i);
                    count++;
                }
            }
            foreach (int i in primes)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
