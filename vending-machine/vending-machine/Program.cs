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
            Keypad keypad = new Keypad();

            do
            {
                display.Greeting();
                input = keypad.TakeInput();
                balanceSystem.cashOrCard(input, display, keypad);
            } while (!(input == "card" || input == "cash"));

            display.DisplayStock();
        }

        public void Other()
        {
        }
        
    }
}
