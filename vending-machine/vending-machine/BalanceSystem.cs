using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class BalanceSystem
    {
        public decimal balance = 0;

        public void Balance(decimal input)
        {
            balance += input;
        }
    }
}
