using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    //internal class Encapsulation
    //{
    //}
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber { get { return accountNumber; } }
        public double Balance
        { get { return balance; }
            set { if (value>0) balance=value; else { Console.WriteLine("balance is not valid"); } } }
        public  BankAccount(string accountnumb)
        {
            accountNumber=accountnumb;
        }

    }
    
}
