using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Program
    {

        static void Main(string[] args)
        {
            var input = "";
            Display display = new Display();
            BalanceSystem balanceSystem = new BalanceSystem();
            StockItem.CreateStock();

            do
            {
                Console.WriteLine(display.Greeting());
                input = Keypad.TakeInput();
                balanceSystem.cashOrCard(input);
            } while (!(input == "card" || input == "cash"));
        }

        public void Other()
        {
        }
        
    }
}
