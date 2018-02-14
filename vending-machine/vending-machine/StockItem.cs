using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class StockItem
    {
        private string name;
        private double price;
        private int id;

        public StockItem(string n, double p, int i)
        {
            this.name = n;
            this.price = p;
            this.id = i;
        }

        public static void CreateStock()
        {
            StockItem snicker = new StockItem("Snicker", 1, 0);
            StockItem marsBar = new StockItem("Mars bar", 1, 1);
            StockItem kitkat = new StockItem("Kitkat", 1, 2);
            StockItem smarties = new StockItem("Smarties", 0.5, 3);
            StockItem water = new StockItem("Water", 0.5, 4);
            StockItem coke = new StockItem("Coke", 0.79, 5);
            StockItem fanta = new StockItem("Fanta", 0.79, 6);
            StockItem iceTea = new StockItem("Ice tea", 1.29, 7);
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetId()
        {
            return id;
        }
    }
}
