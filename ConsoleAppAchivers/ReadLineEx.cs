using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class ReadLineEx
    {
        public void ReadLineMethod()
        {
            Console.WriteLine("Enter Ur Name");
            string Name = Console.ReadLine();  // scanf in C
            Console.WriteLine($"Name u Have Entered is {Name} ");



            Console.WriteLine("Enter Ur AGe");
            byte Age = Convert.ToByte(Console.ReadLine());
            // lhs byte =rhs string
            Console.WriteLine($"Age is {Age}");

            Console.WriteLine("Enter Ur Aadhar");
            int Aadhar = Convert.ToInt32(Console.ReadLine());
            // lhs byte =rhs string
            Console.WriteLine($"Aadhar is {Aadhar}");

            // 4byte = 2 byte
        }

    }
}
