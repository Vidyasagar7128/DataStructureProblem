using System;
using System.IO;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure!");
            DataStructure<string> dataStructure = new DataStructure<string>();
            string str = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            string[] str1 = str.Split("(");
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == '(')
                {
                    dataStructure.Push("(");
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ')')
                {
                    dataStructure.Pop();
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(str);
            Console.WriteLine("----------------------------");
            if(dataStructure.Show() == 0)
                Console.WriteLine("Arithmetic Expression is Balanced.");
            else
                Console.WriteLine("Arithmetic Expression is Not Balanced.");
        }
    }
}
