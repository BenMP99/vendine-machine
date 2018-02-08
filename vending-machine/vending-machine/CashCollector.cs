using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class CashCollector
    {
        public void TakeCash()
        {
            Console.WriteLine("How much cash are you inserting?");
            BalanceSystem balanceSystem = new BalanceSystem();
            balanceSystem.Balance(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
