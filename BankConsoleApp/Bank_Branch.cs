using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    class Bank_Branch
    {
        public int IDnumber { set; get; }// bank adress
        //public DateTime Date { get; }
        public string Bankname { set; get; }// bank name
        private List<Cashier> allCashiers = new List<Cashier>();
        private List<Transaction> allTransactions=new List<Transaction>();
        private List<Client> clients = new List<Client>();

        public Bank_Branch(string name,int ID)//constructor
        {
            this.Bankname =name;
            this.IDnumber = ID;
            //this.Date = date;
        }

    }
}
