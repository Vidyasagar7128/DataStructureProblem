using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure!");
            DataStructure<string> dataStructure = new DataStructure<string>();
            string str = "read the text from a file";
            string[] str1 = str.Split(" ");
            for(int i = 0; i < str1.Length; i++)
            {
                dataStructure.Add(str1[i]);
            }
            dataStructure.Show();
            Console.WriteLine();
            Console.WriteLine("Search Word or Add.");
            string name = Console.ReadLine();
            Console.WriteLine(dataStructure.Search(name));
            bool present = dataStructure.Search(name);
            if (present)
            {
                Console.WriteLine("Data are Present.");
                Console.WriteLine();
                dataStructure.RemoveData(name);
                Console.WriteLine();
            }

            else
            {
                dataStructure.Add(name);
                Console.WriteLine("Word Added to LinkedList");
                Console.WriteLine();
            }
            dataStructure.Show();
        }
    }
}
