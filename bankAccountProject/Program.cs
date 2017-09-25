using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client brad = new Client();
            //Account bradBerger0 = new Account();
            Checking bradBerger1 = new Checking();
            Savings bradBerger2 = new Savings();

            int menuNumber = 1;
            while (menuNumber != 5)
            {
                brad.MainMenu();
                menuNumber = int.Parse(Console.ReadLine());

                if (menuNumber == 1)
                {
                    brad.PrintClientInfo();
                }
                else if (menuNumber == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Which account would you like to view?");
                    Console.WriteLine("a. Checking");
                    Console.WriteLine("b. Savings");
                    Console.WriteLine(" ");

                    char checkingOrSavings = char.Parse(Console.ReadLine());
                    if (checkingOrSavings == 'a' || checkingOrSavings == 'A')
                    {
                        bradBerger1.ViewBalance();
                        //brad.MainMenu();
                        //menuNumber = int.Parse(Console.ReadLine());
                    }
                    else if (checkingOrSavings == 'b' || checkingOrSavings == 'b')
                    {
                        bradBerger2.ViewBalance();
                        //brad.MainMenu();
                        //menuNumber = int.Parse(Console.ReadLine());
                    }
                }
                else if (menuNumber == 3)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Which account would you like deposit to?");
                    Console.WriteLine("a. Checking");
                    Console.WriteLine("b. Savings");
                    Console.WriteLine(" ");

                    char checkingOrSavings = char.Parse(Console.ReadLine());
                    if (checkingOrSavings == 'a' || checkingOrSavings == 'A')
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Enter amount to be deposited to checking");
                        bradBerger1.AddAmount = double.Parse(Console.ReadLine());
                        bradBerger1.Deposit();

                        //brad.MainMenu();
                        //menuNumber = int.Parse(Console.ReadLine());
                    }
                    else if (checkingOrSavings == 'b' || checkingOrSavings == 'b')
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Enter amount to be deposited to Savings");
                        bradBerger2.AddAmount = double.Parse(Console.ReadLine());
                        bradBerger2.Deposit();
                        //brad.MainMenu();
                        //menuNumber = int.Parse(Console.ReadLine());
                    }
                }
                else if (menuNumber == 4)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Which account would you like withdraw from?");
                    Console.WriteLine("a. Checking");
                    Console.WriteLine("b. Savings");
                    Console.WriteLine(" ");

                    char checkingOrSavings = char.Parse(Console.ReadLine());
                    if (checkingOrSavings == 'a' || checkingOrSavings == 'A')
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Enter amount to be withdrawn from Checking");
                        bradBerger1.SubtractAmount = double.Parse(Console.ReadLine());
                        bradBerger1.Withdrawl();
                        //brad.MainMenu();
                        //menuNumber = int.Parse(Console.ReadLine());
                    }
                    else if (checkingOrSavings == 'b' || checkingOrSavings == 'b')
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Enter amount to be withdrawon from Savings");
                        bradBerger2.SubtractAmount = double.Parse(Console.ReadLine());
                        if (bradBerger2.Balance - bradBerger2.SubtractAmount < 200)
                        {
                            Console.WriteLine("You can not withdraw due to minimum balance requirements");
                         
                        }
                        else
                        {
                            bradBerger2.Withdrawl();
                           
                        }
                    }
                }
                else if (menuNumber ==5)
                {
                    Console.WriteLine("Thank you for using the ATM. Good-bye!");
                    break;
                }
                
            }
        }
    }
}
            
           
           
        




            //brad.PrintClientInfo();
        
    

