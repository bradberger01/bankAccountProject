using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountProject
{
    abstract class Account //BASE CLASS
    {
        //FIELDS
        protected int accountNumber;
        protected double balance;
        protected string accountType;
        
        //PROPERTIES
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
        
        //CONSTRUCTORS
        public Account()//DEFAULT
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

        public virtual void ViewBalance() //VIEW BALANCE METHOD
        {
            Console.WriteLine(this.accountNumber);
            Console.WriteLine(this.accountType);
            Console.WriteLine(this.balance);
        }
        public abstract void Deposit(); //DEPOSIT METHOD
       
        public virtual void Withdrawl() //WITHDRAWL METHOD
        {
            Console.WriteLine(this.balance);
        }
        

    }
}
