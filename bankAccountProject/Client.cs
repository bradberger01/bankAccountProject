using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountProject
{
    class Client
    {
        //FIELDS
        private string userName;
        private int checkingAccountNum;
        private int savingsAccountNum;
        private int selectAccountType;
    
        //PROPERTIES
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public int CheckingAccountNum
        {
            get { return this.checkingAccountNum; }
            set { this.checkingAccountNum = value; }
        } 
        public int SavingsAccountNum
        {
            get { return this.savingsAccountNum; }
            set { this.savingsAccountNum = value; }
        }
        public int SelectAccountType
        {
            get { return this.selectAccountType; }
            set { this.selectAccountType = value; }
        }
      
        //CONSTRUCTORS
        public Client() //DEFAULT
        {
            this.userName = "Brad Berger";
            this.checkingAccountNum = 123456789;
            this.savingsAccountNum = 987654321;
        }
        
        public void PrintClientInfo()
        {
            Console.WriteLine(userName);
            Console.WriteLine("Checking Account Number: " + checkingAccountNum);
            Console.WriteLine("Savings Account Number: " + savingsAccountNum);
        }
        public void MainMenu() //CW MAIN MENU METHOD
        {
            Console.WriteLine(" ");
            Console.WriteLine("Please select from the menu below.");
            Console.WriteLine(" ");
            Console.WriteLine("1. View client information");
            Console.WriteLine("2. View account balance");
            Console.WriteLine("3. Make a deposit");
            Console.WriteLine("4. Make a withdrawl");
            Console.WriteLine("5. Exit");
            Console.WriteLine(" ");

        }
        public void SelectAccount() //SELECT SPECIFIC ACCOUNT METHOD
        {
            Console.WriteLine("Which account would you like to view?");
            Console.WriteLine("1. Checking");
            Console.WriteLine("2. Savings");
        }

    }
}
