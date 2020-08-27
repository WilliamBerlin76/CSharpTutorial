using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new List<string> { "<name>", "Boobie", "Bobby" };

            names.Add("frank");
            names.Remove("<name>");
            
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name}");
            }
        }
    }
}