using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class StockItemList
    {
        List<StockItem> stockList = new List<StockItem>();

        public StockItemList()
        {
            StockItem snicker = new StockItem("Snicker", 1, 0);
            StockItem marsBar = new StockItem("Mars bar", 1, 1);
            StockItem kitkat = new StockItem("Kitkat", 1, 2);
            StockItem smarties = new StockItem("Smarties", 0.5, 3);
            StockItem water = new StockItem("Water", 0.5, 4);
            StockItem coke = new StockItem("Coke", 0.79, 5);
            StockItem fanta = new StockItem("Fanta", 0.79, 6);
            StockItem iceTea = new StockItem("Ice tea", 1.29, 7);

            stockList.Add(snicker);
            stockList.Add(marsBar);
            stockList.Add(kitkat);
            stockList.Add(smarties);
            stockList.Add(water);
            stockList.Add(coke);
            stockList.Add(fanta);
            stockList.Add(iceTea);
        }

        public List<StockItem> GetList()
        {
            return stockList;
        }
    }
}
