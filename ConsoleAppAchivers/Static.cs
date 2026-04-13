using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class Static  // non stati
    {
        public Static()
        {  // constructor method ,, directly its exe
            Console.WriteLine("test constr");
        }
        public void M1() // instance method  (obejct)  
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

        // Non Static
        // Staic Method
        // Constr Method  // method name is same as class name  ,, dont  return type
    }
}
