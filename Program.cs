using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount("William", 100);

            Console.WriteLine($"Account {myAccount.Number} with owner {myAccount.Owner} with {myAccount.Balance}");
            myAccount.MakeDeposit(234, DateTime.Now, "first deposit");
            Console.WriteLine($"Account {myAccount.Number} with owner {myAccount.Owner} with {myAccount.Balance}");
            //myAccount.MakeDeposit(-234, DateTime.Now, "first deposit");
            //Console.WriteLine($"Account {myAccount.Number} with owner {myAccount.Owner} with {myAccount.Balance}");
            myAccount.MakeWithdrawal(234, DateTime.Now, "first withdrawal");
            Console.WriteLine($"Account {myAccount.Number} with owner {myAccount.Owner} with {myAccount.Balance}");
            /*myAccount.MakeWithdrawal(-101, DateTime.Now, "first withdrawal");
            Console.WriteLine($"Account {myAccount.Number} with owner {myAccount.Owner} with {myAccount.Balance}");
            */
        }
    }
}