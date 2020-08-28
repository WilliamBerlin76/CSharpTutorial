using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance 
        { 
            get 
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Ammount;
                }
                return balance;
            } 
        }

        private static int accountNumberSeed = 1234567890;

        List<Transaction> allTransactions = new List<Transaction> {};

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();

            MakeDeposit(initialBalance, DateTime.Now, "initial balance");
            accountNumberSeed++;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);

        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Amount may not be greater than balance");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}
