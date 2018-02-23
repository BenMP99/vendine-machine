using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class CashCollector : IPaymentIn
   {
        public void TakePayment(Display display, Keypad keypad)
        {
            BalanceSystem balanceSystem = new BalanceSystem();
            balanceSystem.Balance(Math.Round(Convert.ToDecimal(keypad.TakeBalance(display)), 2));
            
            display.DisplayBalance();
        }
    }
}
