using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    static class StaticConstrExample
    {
        static StaticConstrExample()
        {
            Console.WriteLine("Static constructor called.");
        }

        public static void DisplayMessage()
        {
            Console.WriteLine("Hello from the static method!");
        }   
    }
}
