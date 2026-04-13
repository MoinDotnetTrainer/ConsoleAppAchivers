using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleAppAchivers
{
    class Parent
    {
        protected int x, y, z;
        public void Add()
        {
            x = 4;
            y = 46;
            z = x + y;
            Console.WriteLine("add is:" + z);
        }
        public void Sub()
        {
            x = 344;
            y = 546;
            z = x - y;
            Console.WriteLine("Sub: " + z);
        }
    }

    class Child : Parent
    {

        public void Mul()
        {
            Add();
            Sub();
            x = 4;
            y = 46;
            z = x * y;
            Console.WriteLine("Mul is:" + z);
        }
        public void Div()
        {
            x = 344;
            y = 546;
            z = x / y;
            Console.WriteLine("Div: +" + z);
        }
    }

    class Child1 : Parent
    {

        public void Remin()
        {
            x = 4;
            y = 46;
            z = x % y;
            Console.WriteLine("rem is:" + z);
        }

    }

    class Gp
    {
        public int x, y, z;
    }

    class P : Gp
    {

        public int a, b, c;
        public void Access()
        {
            x = 45;
        }
    }

    class C : P
    {
        public void Get()
        {
            c = 45;
            x = 56;
        }
    }
}
