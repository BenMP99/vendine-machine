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
        public void ShouldAssignTheBalance()
        {
            BalanceSystem balanceSystem = new BalanceSystem();
            Display display = new Display();
            balanceSystem.Balance(2.80M);

            display.DisplayBalance();
        }
    }
}
