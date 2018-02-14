using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    class Keypad
    {
        public static string TakeInput()
        {
            var input = Console.ReadLine().ToLower();
            return input;
        }
    }
}
