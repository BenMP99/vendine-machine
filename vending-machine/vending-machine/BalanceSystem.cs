using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class BalanceSystem : IPaymentOut
    {
        public int Balance(int input)
        {
            var balance = input;
            return balance;
            //does this need to return value? Cant just call it then to access balance variable. But needs to return for interface. Cant access balance in ChangeDispenser without returning.
        }

        public void cashOrCard(string input)
        {
            if (input == "cash")
            {
                CashCollector cashCollector = new CashCollector();
                cashCollector.TakeCash();
            }
            else if (input == "card")
            {
                CardSlot cardSlot = new CardSlot();
                cardSlot.takeCard(true);
            }
        }
    }
}
