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
            Display display = new Display();

            if (BalanceSystem.balance > 0)
            {
                BalanceSystem.balance = 0;
                display.DispenseChange();
            }
            else
            {
                display.NoChangeToDispense();
            }
        }
    }
}
