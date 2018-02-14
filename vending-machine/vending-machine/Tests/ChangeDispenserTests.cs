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
        public void ShoudDisplayCorrectMessageWhenBalanceIsGreaterThan0()
        {
            BalanceSystem balanceSystem = new BalanceSystem();
            ChangeDispenser changeDispenser = new ChangeDispenser();

            balanceSystem.balance = 10;

            changeDispenser.DispenseChange();
        }
    }
}
