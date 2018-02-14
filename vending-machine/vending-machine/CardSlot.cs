using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class CardSlot : IPaymentIn
    {
        public bool cardInserted = false;

        public void TakePayment()
        {
            cardInserted = true;
        }
    }
}
