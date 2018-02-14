using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    public class Display
    {
        public string Greeting()
        {
            return "Please insert either cash to add balance, or a card";
        }

        public void AskCashOrCard()
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
 
    }
}
