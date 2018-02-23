using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class BalanceSystem
    {
        public static decimal balance = 0;
        
        public void Balance(decimal input)
        {
            balance += input;
        }

        public void cashOrCard(string input, Display display, Keypad keypad)
        {
            if (input == "cash")
            {
                CashCollector cashCollector = new CashCollector();
                cashCollector.TakePayment(display, keypad);
            }
            else if (input == "card")
            {
                CardSlot cardSlot = new CardSlot();
                cardSlot.TakePayment(display, keypad);
            }
        }
    }
}
