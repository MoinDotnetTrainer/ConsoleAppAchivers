using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleAppAchivers
{
    internal class GenMethods
    {
        public void Test(int x, int y)
        {
            // This method Uses datatype as an Argument
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        // Generic Methd which uses type as an argument  
        // and that type will be decided at the time of calling the method
        // 
        public void GetData<type1>(type1 x) {
            Console.WriteLine(x);  
        }
        public void GetData<type1, type2>(type1 x, type2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }   

        public void GetResults<type1, type2, type3>(type1 x, type2 y, type3 z)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }   
    }
}
