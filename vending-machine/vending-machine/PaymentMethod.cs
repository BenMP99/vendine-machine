using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class PaymentMethod
    {
        private readonly CashCollector _cashCollector;
        private readonly CardSlot _cardSlot;

        public PaymentMethod(CashCollector cashCollector, CardSlot cardSlot)
        {
            _cashCollector = cashCollector;
            _cardSlot = cardSlot;
        }
        public void Choose(string input, BalanceSystem balanceSystem)
        {
            if (input == "cash")
            {
                _cashCollector.TakePayment(balanceSystem);
            }
            else if (input == "card")
            {
                _cardSlot.TakePayment(balanceSystem);
            }
        }
    }
}
