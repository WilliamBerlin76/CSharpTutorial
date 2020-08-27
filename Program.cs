using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount("William", 1000);

            Console.WriteLine($"Account {myAccount.Owner} with {myAccount.Balance}");
        }
    }
}