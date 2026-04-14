using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class CalbyValRef
    {
        public void Data1()
        {
          //  return 12;

            // compiler error because the method is void and we are trying to return a value
        }

        public int Data2()
        {
            return 12;
        }

        public (int, string) Data3()
        {
            return (12, "Test");
        }

        public void Cal(int x, int y, out int Sum, out int Sub)
        {
            Sum = x + y;
            Sub = x - y;
        }


        public void Cal(ref int x)  // x=10
        {
            Console.WriteLine(" x Value Before call:" + x);  // 10
            x = x + 10;  //
            Console.WriteLine("x Value after Call:" + x);  // 20
        }


        public void Exe()
        {
            int y = 10;  // Y value will never change
            Console.WriteLine("Y before passing:" + y);  // y = 10
            Cal(ref y);// cal by value
            Console.WriteLine("Y after passing:" + y);  // y =20
        }

        // y = 1010101
        // x = 1234 ,1010101 
    }
}
