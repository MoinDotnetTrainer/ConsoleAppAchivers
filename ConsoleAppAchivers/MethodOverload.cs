using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class MethodOverload
    {
        public void Task()
        { // 0 pm method
            Console.WriteLine("task1");
        }
        public void Task(string Bat)
        { // 0 pm method
            Console.WriteLine("Batting");
        }

        public void Task(int Overs)
        { // 0 pm method
            Console.WriteLine("No of Overs");
        }
        public void Task(int x, int y)
        {
            Console.WriteLine("2 int task");
        }
        public void Task(string x, int y)
        {
            Console.WriteLine("string int int task");
        }
        public void Task(int x, string y)
        {
            Console.WriteLine("2 int  string task");
        }
    }
}
