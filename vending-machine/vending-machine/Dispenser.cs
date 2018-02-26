using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class Dispenser
    {
        public void DispenseStock(int stockId, StockItemList stockItemList, CardSlot cardSlot, Keypad keypad, ChangeDispenser changeDispenser, Display display, BalanceSystem balanceSystem)
        {
            List<StockItem> calledList = stockItemList.GetList();

            for (int i = 0; i < calledList.Count; i++)
            {
                if ((stockId - 1) == calledList[i].GetId() && (cardSlot.cardInserted == true || BalanceSystem.balance >= calledList[i].GetPrice()))
                {
                    Console.WriteLine("Item has been dispensed.");
                    balanceSystem.Balance(-calledList[i].GetPrice());
                }
                else if((stockId - 1) == calledList[i].GetId() && (cardSlot.cardInserted == true || BalanceSystem.balance < calledList[i].GetPrice()))
                {
                    Console.WriteLine("Not enough money has been deposited to buy this item.");
                }
            }

            Console.WriteLine("Type 'again' to buy another item, or press enter to dispense your remaining balance.");
            if (keypad.TakeInput() == "again")
            {
                display.DisplayBalance();
                display.DisplayStock();
                DispenseStock(keypad.TakeStockItem(), stockItemList, cardSlot, keypad, changeDispenser, display, balanceSystem);
            }
            else
            {
                changeDispenser.DispenseChange();
                Console.ReadLine();
            }
        }
    }
}
