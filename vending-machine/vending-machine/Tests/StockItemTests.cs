using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace vending_machine.Tests
{
    [TestFixture]
    class StockItemTests
    {
        [Test]
        public void ShouldAssignAttributesUsingConstructor()
        {
            StockItem water = new StockItem("Water", 0.5, 0);

            Assert.AreEqual("Water", water.GetName());
            Assert.AreEqual(0.5, water.GetPrice());
            Assert.AreEqual(0, water.GetId());
        }

    }
}
