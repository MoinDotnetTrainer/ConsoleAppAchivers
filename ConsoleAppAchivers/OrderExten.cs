using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    static class OrderExten
    {
        public static void OrderDetails(this Orders obj,int x , int y)
        {
            Console.WriteLine("Order Details");
        }
    }
}
