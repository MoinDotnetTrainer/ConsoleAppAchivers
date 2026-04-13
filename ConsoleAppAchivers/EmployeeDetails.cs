using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class EmployeeDetailsAdminDept
    {
        public virtual void EmpCount() {
            Console.WriteLine("No of EMployyes in Admin is 10");
        }

        public virtual void Salary() {
            Console.WriteLine("Salry for all Admin EMp is 1CR");
        }

        public void Projects() {
            Console.WriteLine("No of are 5");
        }
    }

    class ITDept : EmployeeDetailsAdminDept
    {
       
        public void Projects()
        {
            Console.WriteLine("No of are 10");
        }
    }

    class HRDept : EmployeeDetailsAdminDept
    {
        public override void EmpCount()
        {
            Console.WriteLine("No of EMployyes in HR is 15");
        }
        public void Salary()
        {
            Console.WriteLine("Salry for all HR EMp is 1.5CR");
        }
        public void Projects()
        {
            Console.WriteLine("No of are 7");
        }
    }   
}
