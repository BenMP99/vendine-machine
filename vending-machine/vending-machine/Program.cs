using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Program
    {

        static void Main(string[] args)
        {
            var input = "";
            Display display = new Display();
            Keypad keypad = new Keypad();
            CashCollector cashCollector = new CashCollector(display, keypad);
            CardSlot cardSlot = new CardSlot(display, keypad);
            PaymentMethod paymentMethod = new PaymentMethod(cashCollector, cardSlot);
            Dispenser dispenser = new Dispenser();
            StockItemList stockItemList = new StockItemList();
            ChangeDispenser changeDispenser = new ChangeDispenser();
            BalanceSystem balanceSystem = new BalanceSystem();

            do
            {
                display.Greeting();
                input = keypad.TakeInput();
                paymentMethod.Choose(input);
            } while (!(input == "card" || input == "cash"));

            display.DisplayStock();
            dispenser.DispenseStock(keypad.TakeStockItem(), stockItemList, cardSlot, keypad, changeDispenser, display, balanceSystem);
        }
        
    }
}
