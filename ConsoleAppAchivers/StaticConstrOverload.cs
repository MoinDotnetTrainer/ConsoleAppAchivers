using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    static class StaticConstrOverload
    {
        static StaticConstrOverload()  // implict , auto
        {
            Console.WriteLine("0 PM Constructor default constr , implict");
        }


        public static void M1() // instance method  (obejct)  
        {  // Non Static Method 
            Console.WriteLine("M1 Method with O PM");
        }

        public static void M2(string str)
        {  // static
            Console.WriteLine("M2");
        }
        public static void M3()
        {
            Console.WriteLine("M3");
        }
    }
}
