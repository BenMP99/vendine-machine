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
            Keypad keypad = new Keypad();
            CashCollector cashCollector = new CashCollector(display, keypad);
            CardSlot cardSlot = new CardSlot(display, keypad);
            PaymentMethod paymentMethod = new PaymentMethod(cashCollector, cardSlot);

            do
            {
                display.Greeting();
                input = keypad.TakeInput();
                paymentMethod.Choose(input);
            } while (!(input == "card" || input == "cash"));

            display.DisplayStock();
        }
        
    }
}
