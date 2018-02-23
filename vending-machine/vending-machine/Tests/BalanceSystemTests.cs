using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace vending_machine.Tests
{
    [TestFixture]
    class BalanceSystemTests
    {
        [Test]
        public void ShouldAddToBalance()
        {
            BalanceSystem balanceSystem = new BalanceSystem();
            balanceSystem.Balance(3);
            Assert.AreEqual(3, BalanceSystem.balance);
        }
    }
}
