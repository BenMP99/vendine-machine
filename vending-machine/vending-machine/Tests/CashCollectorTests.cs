using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace vending_machine.Tests
{
    [TestFixture]
    class CashCollectorTests
    {
        [Test]
        public void BalanceIsAssignedTo()
        {
            BalanceSystem balanceSystem = new BalanceSystem();
            CashCollector cashCollector = new CashCollector();

            cashCollector.TakeCash();
        }
    }
}
