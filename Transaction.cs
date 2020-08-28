using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Transaction
    {
        public decimal Ammount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction (decimal ammount, DateTime date, string notes)
        {
            this.Ammount = ammount;
            this.Date = date;
            this.Notes = notes;
        }

    }
}
