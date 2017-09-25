using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountProject
{
    class Account
    {
        protected int accountNumber;
        protected double balance;
        protected string accountType;
        
        



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
            this.accountType = "Checking";
            this.accountNumber = 234567891;
            this.balance = 5000.00d;
        }
        public Account(string accountType, int accountNumber, double balance)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual void ViewBalance()
        {
            Console.WriteLine(this.accountNumber);
            Console.WriteLine(this.accountType);
            Console.WriteLine(this.balance);
        }
        public virtual void Deposit()
        {
            Console.WriteLine(this.balance);

        }
        public virtual void Withdrawl()
        {
            Console.WriteLine(this.balance);
        }
        

    }
}
