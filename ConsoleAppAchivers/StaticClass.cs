using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    static class StaticClass
    {
        static StaticClass() // static constructor 
        {
            Console.WriteLine("Static Constructor");
        }

       
        public static void M1() // instance method  (obejct)  
        {  // Non Static Method 
            Console.WriteLine("M1 Method with O PM");
        }

        public static void M4(string str) // instance method  (obejct)  
        {  // Non Static Method 
            Console.WriteLine("M1 Method with O PM");
        }

        public static void M2()
        {  // static
            Console.WriteLine("M2");
        }
        public static void M3()
        {
            Console.WriteLine("M3");
        }
    }
}
