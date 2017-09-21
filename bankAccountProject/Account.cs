using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountProject
{
    class Account
    {
        private int accountNumber;
        private double balance;
        private string accountType;
     


        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
       

        public Account()
        {

        }
        public Account(string accountType, int accountNumber, double balance)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual void ViewBalance()
        {
            Console.WriteLine(balance);
        }
        public virtual void Deposit()
        {
            Console.WriteLine("Which account would you like to make a deposit to?");
        }
        public virtual void Withdrawl()
        {
            Console.WriteLine("Which account would you like to make a withdrawl from?");
        }

    }
}
