using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            Display display = new Display();
            BalanceSystem balanceSystem = new BalanceSystem();

            Console.WriteLine(display.Greeting());

            do
            {
                input = Console.ReadLine().ToLower();
                balanceSystem.cashOrCard(input);
            } while (!(input == "card" || input == "cash"));
        }
        
    }
}
