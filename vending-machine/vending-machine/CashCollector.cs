using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class CashCollector : IPaymentIn
   {
       private readonly Display _display;
       private readonly Keypad _keypad;

       public CashCollector(Display display, Keypad keypad)
       {
           _display = display;
           _keypad = keypad;
       }
        public void TakePayment()
        {
            BalanceSystem balanceSystem = new BalanceSystem();
            balanceSystem.Balance(Math.Round(Convert.ToDecimal(_keypad.TakeBalance(_display)), 2));
            
            _display.DisplayBalance();
        }
    }
}
