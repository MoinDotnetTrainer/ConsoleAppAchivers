using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class GenClass
    {
        public static void Gen<t1, t2>(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public static void Gen1<t1, t2>(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public static void Gen2<t1, t2>(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public static void Gen3<t1, t2>(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public static void Gen4<t1, t2>(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    internal class GenClass1<t1, t2>
    {
        public  void Gen(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public  void Gen1(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public  void Gen2(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public  void Gen3(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public  void Gen4(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public  void Gen5(t1 x)
        {
            Console.WriteLine(x);
        }
    }

}
