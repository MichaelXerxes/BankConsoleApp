using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    class Transaction
    {
        //global variables
        public decimal Ammount { get; }
        public DateTime Date { get; }
        public string Notes { get; }
        public string CashierID { set; get; }
        private Cashier cashier { set; get; }

        public Transaction(decimal ammount, DateTime date, string note,String cashierID)
        {
            this.Ammount = ammount;
            this.Date = date;
            this.Notes = note;
            this.CashierID = cashierID;
        }
        public string toStringTransaction() // method return string format
        {
            string str;//local variable
            str = ($"DateTime :{Date} \tAmmount: {Ammount} Cashier ID: {CashierID} Note :{Notes}  ");
            return str;
        }
    }
}
