using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure!");
            DataStructure dataStructure = new DataStructure();
            string[] words = { "decs", "read", "logic", "search" };
            string data = "search";
            int result = dataStructure.FindWord(words, data);
            if (result == -1)
                Console.WriteLine("Word not present");

            else
                Console.WriteLine("Word is found at " + result);
        }
    }
}
