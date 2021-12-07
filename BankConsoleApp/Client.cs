using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Client class 
namespace BankConsoleApp
{
    class Client {
        public string Name { set; get; }
        public string IDnumber { set; get; }
        private BankAccount account { set; get; }

        public Client(string name,string ID,BankAccount bankAccount)//constructor with 3 parameters
        {
            this.Name = name;
            this.IDnumber = ID;
            this.account = bankAccount;
        }
        public string getBankAccountDetails(BankAccount account)// method to return account details in string format
        {
            var details = new StringBuilder();
            details.AppendLine("\nNumber\t\tAccount Type\t\tBalance");
        
               details.AppendLine($"{account.Number}\t{account.Owner}\t{account.Balance}\n");
            return details.ToString();
;
        }
            


    }
}
