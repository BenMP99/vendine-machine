using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class CashCollector : IPaymentIn
   {
        public void TakePayment()
        {
            Display display = new Display();
            display.AskCashOrCard();

            BalanceSystem balanceSystem = new BalanceSystem();
            balanceSystem.Balance(Convert.ToDecimal(Keypad.TakeInput()));

            Console.WriteLine(balanceSystem.balance);
            Console.ReadLine();
        }
    }
}
