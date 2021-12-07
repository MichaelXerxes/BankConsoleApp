using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    class Cashier
     
    {
        public string id { set; get; }
        public string name { set; get; }
        public Bank_Branch bank_Branch { set; get; }
        public Cashier(string name,string id,Bank_Branch branch)//constructor with 3 parameters
        {
            this.id = id;
            this.name = name;
            this.bank_Branch = branch;
        }

    }
}
