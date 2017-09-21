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
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public Account()
        {

        }

        public virtual void ViewBalance()
        {

        }

    }
}
