using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate void Cal1();
public delegate int Cal2(int x , int y);
namespace ConsoleAppAchivers
{
    class DelegatesExample
    {
        public void Add()  // signature of the method   
        {
            Console.WriteLine(":Add");
        } // impementation of the method    
        public void Sub()
        {
            Console.WriteLine(":sub");
        }
        public static int mul(int x , int y)
        {
            Console.WriteLine(":Mul");
            return x * y;
        }
        public static int Div(int  x, int y)
        {
            Console.WriteLine(":Div");
            return x / y;
        }
    }
}
