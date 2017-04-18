using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationProgram
{
    class GlobalVariablesClass
    {
        //Sets a blank variable
        private static string CustomerID = "";
        //Methods to assign the variable as well as return it to wherever it is referenced
        public static string customerID
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }

        private static string accountNum = "";

        public static string accountNumber
        {
            get { return accountNum; }
            set { accountNum = value; }
        }
    }
}
