using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp

{
    class BankAccount
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

        private int accountNumberSeed = 1234567890;
       // public Cashier cashier1;
        

        private List<Transaction> allTransactions=new List<Transaction>();// History of transaction

        public BankAccount(string name, decimal initialBalance,string cashierID)
        {
            this.Owner = name;
            MakeDeposit(initialBalance,DateTime.Now, "Initial Balance",cashierID);

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal ammount, DateTime date, string note,string cashierID)
        {
            if (ammount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ammount), "Ammount if deposit must be positive");
            }

            var deposit = new Transaction(ammount, date, note,cashierID);
            allTransactions.Add(deposit);

        }

        public void MakeWithdrawal(decimal ammount, DateTime date, string note,string cashierID)
        {
            if (ammount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ammount), "Ammount if deposit must be positive");
            }

            if (Balance - ammount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-ammount, date, note,cashierID);
            allTransactions.Add(withdrawal);
            
        }
        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            //Header
            report.AppendLine("Date\t\t\tAmount\tNote\t\tCashier");
            foreach (var item in allTransactions)
            {
                //Rows
                report.AppendLine($"{item.Date}\t{item.Ammount}\t{item.Notes}\t{item.CashierID}");

            }

            return report.ToString();
            
        }
    }
}
