using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class Class1
    {

        // Internal means within the project

        // this keyword

        public Class1()
        {
            Console.WriteLine("Constructor of Class1");
        }
        public Class1(int x)
        {
            Console.WriteLine("Constructor of Class1 with 1 int pm");
        }

        public Class1(int x, int y)
        {
            Console.WriteLine("Constructor of Class1 with 2 int pm");
        }

    }

    class Class2 : Class1
    {
        public Class2() : base(67, 45)
        {
            Console.WriteLine("Constructor of Class2");
        }
    }
}
