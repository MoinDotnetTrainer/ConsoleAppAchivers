using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class RBI
    {
        public virtual void WithDraw()
        {
            Console.WriteLine("Withdraw from RBI");
        }

        public virtual void Deposit()
        {
            Console.WriteLine("Deposit to RBI");
        }

        public void EmployeeDetails()
        {
            Console.WriteLine("RBI Employee Details");
        }
    }

    class Hdfc : RBI
    {
        public override void WithDraw()
        {
            Console.WriteLine("Withdraw from HDFC");
        }
        public override void Deposit()
        {
            Console.WriteLine("Deposit to HDFC");
        }
    }

    class Icici: RBI
    {
        public override void WithDraw()
        {
            Console.WriteLine("Withdraw from ICICI");
        }
        public override void Deposit()
        {
            Console.WriteLine("Deposit to ICICI");
        }
    }
}
