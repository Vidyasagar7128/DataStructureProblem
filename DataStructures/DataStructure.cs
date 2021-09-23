using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DataStructure
    {
        public void BubbleSort()
        {
            int[] numbers = { 43, 70, 20, 77, 14 };
            int temp;
            for (int i = 0; i <= numbers.Length - 2; i++)
            {
                for (int j = 0; j <= numbers.Length - 2; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            foreach (int p in numbers)
                Console.Write($"{p}, ");
        }
    }
}
