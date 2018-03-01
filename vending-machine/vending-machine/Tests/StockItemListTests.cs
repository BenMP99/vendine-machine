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
    class StockItemListTests
    {
        [Test]
        public void ShouldCreateAListOfObjects()
        {
            List<StockItem> stockList = new List<StockItem>();
            StockItem snicker = new StockItem("Snicker", 1, 0);

            stockList.Add(snicker);

            Assert.AreEqual("Snicker, 1, 0", snicker.GetName() + ", " + snicker.GetPrice() + ", " + snicker.GetId());
        }
    }
}
