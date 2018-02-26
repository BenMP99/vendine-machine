using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Display
    {
        public void Greeting()
        {
            Console.WriteLine("Please insert either cash to add balance, or a card");
        }

        public void AskCashAmount()
        {
            Console.WriteLine("How much cash are you inserting?");
        }

        public void DispenseChange()
        {
            Console.WriteLine("Remaining balance has been dispensed.");
        }

        public void NoChangeToDispense()
        {
            Console.WriteLine("No remaining balance to dispense");
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Your balance is: £" + BalanceSystem.balance.ToString("F"));
            Console.WriteLine();
        }

        public void DisplayStock()
        {
            StockItemList stockItemList = new StockItemList();
            List<StockItem> calledList = stockItemList.GetList();

            Console.WriteLine("Choose which item you want to purchase by typing the ID.");

            for (int i = 0; i < calledList.Count; i++)
            {
                Console.WriteLine((calledList[i].GetId() + 1) + ". " + calledList[i].GetName() + " - £" + calledList[i].GetPrice().ToString("F"));
            }
        }
    }
}
