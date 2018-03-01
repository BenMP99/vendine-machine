using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class ChangeDispenser
    {
        public void DispenseChange(BalanceSystem balanceSystem)
        {
            Display display = new Display();

            if (balanceSystem.balance > 0)
            {
                balanceSystem.balance = 0;
                display.DispenseChange();
            }
            else
            {
                display.NoChangeToDispense();
            }
        }
    }
}
