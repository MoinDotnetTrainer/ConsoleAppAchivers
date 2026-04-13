using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{

    // Inetrafce is also a class

    // Only Abstrt Methods , helps aching multiple inheritance
    interface Interface1
    {
        void Method1();
    }

    interface Interface2
    {
        void Method2();
    }

    class MyClass
    {
        public int x, y, z;
        public void MyMethod()
        {
            Console.WriteLine("My Method");
        }
    }

    class ActualChild : MyClass, Interface1, Interface2
    {
        public void Data()
        {
            x = 45;
            y = 56;
            z = x + y;

        }

        public void Method1()
        {
            Console.WriteLine("Method 1 from Interface 1");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 from Interface 2");
        }
    }
}