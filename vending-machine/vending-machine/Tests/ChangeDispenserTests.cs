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
            ChangeDispenser changeDispenser = new ChangeDispenser();

            BalanceSystem.balance = 10;

            changeDispenser.DispenseChange();
        }
    }
}
