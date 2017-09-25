using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountProject
{
    class Savings : Account //DERIVATIVE
    {
        //FIELDS
        protected double addAmount;
        protected double subtractAmount;

        //PROPERTIES
        public double AddAmount
        {
            get { return this.addAmount; }
            set { this.addAmount = value; }
        }
        public double SubtractAmount
        {
            get { return this.subtractAmount; }
            set { this.subtractAmount = value; }
        }

        //CONSTRUCTORS
        public Savings() //DEFAULT
        {
            this.accountType = "Savings";
            this.accountNumber = 987654321;
            this.balance = 5000.00;
        }
        public Savings(string accountType, int accountNumber, double balance)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public override void ViewBalance() //VIEW BALANCE OVERRIDE METHOD
        {
            Console.WriteLine(this.accountNumber);
            Console.WriteLine(this.accountType);
            Console.WriteLine(this.balance);
        }
        public override void Deposit() //DEPOSIT OVERRIDE METHOD
        {
            balance = balance + addAmount;
            Console.WriteLine("$" + addAmount + " has been added to Savings");
            Console.WriteLine("$" + balance + " is your new total");

        }
        public override void Withdrawl() //WITHDRAWL OVERRIDE METHOD
        {
            balance = balance - subtractAmount;
            Console.WriteLine("$" + subtractAmount + " has been deduced from Savings");
            Console.WriteLine("$" + balance + " is your new total");
        }


    }
}
