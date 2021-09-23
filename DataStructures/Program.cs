using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure!");
            string[] names = { "One", "Two", "Four", "Six" };
            DataStructure dataStructure = new DataStructure();
            dataStructure.Insertion(names);
        }
    }
}
