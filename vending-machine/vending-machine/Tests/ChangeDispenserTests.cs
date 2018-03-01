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
    class ChangeDispenserTests
    {
        [Test]
        public void ShouldSetBalanceTo0WhenDispensed()
        {
            ChangeDispenser changeDispenser = new ChangeDispenser();
            BalanceSystem balanceSystem = new BalanceSystem();
            balanceSystem.balance = 10;

            changeDispenser.DispenseChange(balanceSystem);

            Assert.AreEqual(0, balanceSystem.balance);

        }
    }
}
