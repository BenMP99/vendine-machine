using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Keypad
    {
        public string TakeInput()
        {
            var input = Console.ReadLine().ToLower();
            Console.Clear();
            return input;
        }

        public string TakeBalance(Display display)
        {
            string input;
            decimal temp;
            do
            {
                Console.Clear();
                display.AskCashAmount();
                input = Console.ReadLine();
            } while (!(decimal.TryParse(input, out temp)));

            Console.Clear();
            return input;
        }

        public int TakeStockItem()
        {
            string input;
            int intInput;
            int temp;
            do
            {
                input = Console.ReadLine();
            } while (!(int.TryParse(input, out temp)));

            intInput = int.Parse(input);
            return intInput;
        }
    }
}
