using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace vending_machine.Tests
{
    [TestFixture]
    class VendingMachineTests
    {
        [Test]
        public void DisplaysGreetingMessage()
        {
            Display display = new Display();
            Assert.AreEqual("Please insert either cash to add balance, or a card", display.Greeting());
        }
    }
}
