using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class ConstrExample
    {
        public ConstrExample():this(35,46)
        {
            Console.WriteLine("Constructor without parameters");
        }
        public ConstrExample(int a):this(5,"test")
        {
            Console.WriteLine($"Constructor with one parameter: {a}");
        }
        public ConstrExample(int a, string b):this()
        { 
            Console.WriteLine($"Constructor with two parameters: {a}, {b}");
        }
        public ConstrExample(int a, int b)
        {
            Console.WriteLine($"Constructor with two parameters: {a}, {b}");
        }
    }
}
