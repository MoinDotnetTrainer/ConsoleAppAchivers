using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class Parsing
    {
        public void ParsingMethod()
        {

            //parsing is converting string to other data types  
            string str = null;
            int num = Convert.ToInt32(str);  // parsing  ,, accepting null values & print zero

            int num1 = int.Parse(str);  // not allowing null values
            Console.WriteLine(num1);  // 45 type int , error or wt
            Console.WriteLine(num1.GetType());


            string str1 = "45.56";
            double d = double.Parse(str1);
            Console.WriteLine(d);  // 45.56 type double 
            Console.WriteLine(d.GetType());


            string str2 = "true";
            bool status = bool.Parse(str2);
            Console.WriteLine(status);  // true type bool   
            Console.WriteLine(status.GetType());
        }
    }
}
