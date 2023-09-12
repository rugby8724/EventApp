using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }
}
