using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class CardSlot : IPaymentIn
    {
        private readonly Display _display;
        private readonly Keypad _keypad;
        public bool cardInserted = false;

        public CardSlot(Display display, Keypad keypad)
        {
            _display = display;
            _keypad = keypad;
        }
        public void TakePayment(BalanceSystem balanceSystem)
        {
            cardInserted = true;
        }
    }
}
