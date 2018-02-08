using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class ChangeDispenser
    {
        public void DispenseChange()
        {
            BalanceSystem balanceSystem = new BalanceSystem();

            if (balanceSystem.Balance() > 0)
            {

            }
        }
    }
}
