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
        private decimal price;
        private int id;
        public static int instances = 0;

        public StockItem(string n, decimal p, int i)
        {
            this.name = n;
            this.price = p;
            this.id = i;
            instances++;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetId()
        {
            return id;
        }
    }
}
