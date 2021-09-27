using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DataStructures
{
    class DataStructure<Gtype>
    {
        public void Account()
        {
            Console.Write("Enter Full Name(Firstname Middlename Lastname): ");
            string name = Console.ReadLine();
            Console.Write("Enter Mobile: ");
            string mobile = Console.ReadLine();
            Console.Write("Enter Join Date: ");
            string date = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Regex rxName = new Regex(@"^[A-Za-z\s]+[A-Za-z\s]+[A-Za-z\s]$");
            Regex rxMobile = new Regex(@"^[1-9]+[-]+[0-9]{10,10}$");
            Regex rxDate = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            string[] firstName = name.Split(" ");
            Console.WriteLine($"Hello {firstName[0]}, We have your fullname as {rxName.Match(name)} in our system.your contact number is {rxMobile.Match(mobile)}.Please, let us know in case of any clarification Thank you BridgeLabz {rxDate.Match(date)}.");
            Account();
        }
    }
}
