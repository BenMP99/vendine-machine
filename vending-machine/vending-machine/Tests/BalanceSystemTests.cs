using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace vending_machine.Tests
{
    [TestFixture]
    class BalanceSystemTests
    {
        [Test]
        public void CallTakeCash()
        {
            var mock = new Mock<CashCollectorTests>();
            mock.Setup(c => c.TakeCash());

            BalanceSystem balanceSystem = new BalanceSystem();
            balanceSystem.cashOrCard("cash");

            mock.Verify(c => c.TakeCash(), Times.Once());
        }
    }
}
