using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    class ProgramBank
    {
      
        static void Main(string[] args)
        {    // creating one branch of one bank
            var Bank=new Bank_Branch("Imperial Bank", 0045);

            var cashier1 = new Cashier("Lisa", "IMP0042", Bank);
            var cashier2 = new Cashier("Noel", "IMP0769", Bank);
            var cashier3 = new Cashier("Kathryn", "IMP6112", Bank);

            //    creation of 3 'clieants and them accounts' objects
            var account1 = new BankAccount("private-standard", 5000,cashier1.id);
            var client1 = new Client("Michael", "0001SRC", account1);

            var account2 = new BankAccount("private-VIP", 1000000, cashier2.id);
            var client2 = new Client("Katy", "0690SLH", account2);


            var account3 = new BankAccount("business-standard", 250000, cashier3.id);
            var client3 = new Client("Food compnay", "FR1231", account3);
            //  try - catch test for negative number
            try
            {
                var invalidAccount = new BankAccount("innvalid", -999, cashier1.id);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Expection caught creating accpunt with negative balance");
                Console.Write(e.ToString());
            }

            account1.MakeWithdrawal(500, DateTime.Now, "shooping", cashier3.id);//call method in class

            account1Data(account1, cashier1.id);//call method                       
            account2Data(account2, cashier2.id);//call method
            account3Data(account3, cashier3.id);//call method

            Console.Write(client1.getBankAccountDetails(account1));
            Console.Write(client2.getBankAccountDetails(account2));
            Console.Write(client3.getBankAccountDetails(account3));

            Console.ReadLine();
        }
        public static void account1Data(BankAccount account1,string cashier)
        {
            Console.Write("\n\n \t\tAccount Balance :  " + account1.Balance + "£\n");
            account1.MakeWithdrawal(3333, DateTime.Now, "Car",cashier);
            account1.MakeWithdrawal(50, DateTime.Now, "something",cashier);
            account1.MakeWithdrawal(5, DateTime.Now, "Coffee",cashier);
            account1.MakeWithdrawal(10, DateTime.Now, "xx",cashier);
            account1.MakeWithdrawal(120, DateTime.Now, "tv",cashier);
            account1.MakeWithdrawal(10, DateTime.Now, "energy",cashier);
            account1.MakeWithdrawal(8, DateTime.Now, "something",cashier);
            Console.WriteLine(account1.GetAccountHistory()); //call method and output results in console
            Console.Write(" \t\tAccount Balance :  " + account1.Balance + "£\n");
        }
        public static void account2Data(BankAccount account2, string cashier)
        {
            Console.Write("\n\n \t\tAccount Balance :  " + account2.Balance + "£\n");
            account2.MakeWithdrawal(3333, DateTime.Now, "holidyas", cashier);           
            account2.MakeWithdrawal(1250, DateTime.Now, "sofa", cashier);
            account2.MakeWithdrawal(50, DateTime.Now, "Dinner", cashier);
            account2.MakeWithdrawal(710, DateTime.Now, "xx", cashier);
            account2.MakeWithdrawal(12120, DateTime.Now, "car", cashier);
            account2.MakeWithdrawal(110, DateTime.Now, "energy", cashier);
            account2.MakeWithdrawal(800, DateTime.Now, "expences", cashier);
            account2.MakeDeposit(5000000, DateTime.Now, "Lottery Win", cashier);
            Console.WriteLine(account2.GetAccountHistory()); //call method and output results in console
            Console.Write(" \t\tAccount Balance :  " + account2.Balance + "£\n");
        }
        public static void account3Data(BankAccount account3, string cashier)
        {
            Console.Write("\n\n \t\tAccount Balance :  " + account3.Balance + "£\n");
            account3.MakeWithdrawal(243003, DateTime.Now, "Car", cashier);
            account3.MakeWithdrawal(250, DateTime.Now, "tools", cashier);
            account3.MakeWithdrawal(50, DateTime.Now, "Lunch", cashier);
            account3.MakeWithdrawal(1710, DateTime.Now, "contract", cashier);
            account3.MakeWithdrawal(2120, DateTime.Now, "mehcanic", cashier);
            account3.MakeWithdrawal(110, DateTime.Now, "energy", cashier);
            account3.MakeWithdrawal(600, DateTime.Now, "expences", cashier);
            account3.MakeDeposit(25000, DateTime.Now, "Income", cashier);
            Console.WriteLine(account3.GetAccountHistory()); //call method and output results in console
            Console.Write(" \t\tAccount Balance :  " + account3.Balance + "£\n");
        }
        public string returnCashier(Cashier cashier)
        {
            string str;
            str = cashier.id;
            return str;

        }

    }
}
