using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class ConstrOverload
    {
        public ConstrOverload()  // implict , auto
        {

            //Parent p = new();
            //p.x = 56;
            //p.Add();
            Console.WriteLine("0 PM Constructor default constr , impluct");
        }
        public ConstrOverload(string name)  // explict
        {
            Console.WriteLine("1 PM Constructor");
        }

        public ConstrOverload(int x, int y)
        {
            Console.WriteLine("2 PM Constructor");
        }
    }
}
