using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountProject
{
    class Checking: Account
    {
        private double addAmount;
        private double subtractAmount;

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
        public Checking()
        {

        }
        public Checking(int accountNumber, string accountType, double balance)
        {
            this.AccountType = accountType;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }
       // public virtual void Deposit(double balance, double addAmount)
       // {
       //   balance = balance + addAmount;
       //     Console.WriteLine("You deposited $" + addAmount);
       //     Console.WriteLine("Your new balance is $" + balance);
       //}
       // public override void Withdrawl(double balance, double subtractAmount)
       // {
       //     balance = balance - subtractAmount;
       //     Console.WriteLine("You withdrew $" + subtractAmount);
       //     Console.WriteLine("Your new balance is $" + subtractAmount);
       // }
    
}
