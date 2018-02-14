using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace vending_machine.Tests
{
    [TestFixture]
    class CardSlotTests
    {
        [Test]
        public void ShouldSetCardInsertedToFalse()
        {
            CardSlot cardSlot = new CardSlot();
            Assert.AreEqual(false, cardSlot.cardInserted);
        }

        [Test]
        public void ShouldSetCardInsertedToTrueAfterCallingTakeCard()
        {
            CardSlot cardSlot = new CardSlot();
            cardSlot.TakePayment();
            Assert.AreEqual(true, cardSlot.cardInserted);
        }
    }
}
