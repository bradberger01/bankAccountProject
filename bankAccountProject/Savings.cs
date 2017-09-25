using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountProject
{
    class Savings : Account
    {
        protected double addAmount;
        protected double subtractAmount;

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
        public Savings()
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

        public override void ViewBalance()
        {
            Console.WriteLine(this.accountNumber);
            Console.WriteLine(this.accountType);
            Console.WriteLine(this.balance);
        }
        public override void Deposit()
        {
            balance = balance + addAmount;
            Console.WriteLine("$" + addAmount + " has been added to Savings");
            Console.WriteLine("$" + balance + " is your new total");

        }
        public override void Withdrawl()
        {
            balance = balance - subtractAmount;
            Console.WriteLine("$" + subtractAmount + " has been deduced from Savings");
            Console.WriteLine("$" + balance + " is your new total");
        }


    }
}
