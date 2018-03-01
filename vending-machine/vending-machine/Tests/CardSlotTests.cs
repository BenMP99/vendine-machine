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
            Display display = new Display();
            Keypad keypad = new Keypad();
            CardSlot cardSlot = new CardSlot(display, keypad);
            Assert.AreEqual(false, cardSlot.cardInserted);
        }

        [Test]
        public void ShouldSetCardInsertedToTrueAfterCallingTakeCard()
        {
            Display display = new Display();
            Keypad keypad = new Keypad();
            BalanceSystem balanceSystem = new BalanceSystem(); 
            CardSlot cardSlot = new CardSlot(display, keypad);
            cardSlot.TakePayment(balanceSystem);
            Assert.AreEqual(true, cardSlot.cardInserted);
        }
    }
}
