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

            brad.MainMenu();

            int menuNumber = int.Parse(Console.ReadLine());




            //brad.PrintClientInfo();
        }
    }
}
