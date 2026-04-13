using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class ClassExample
    {
        public void Add()
        {
            int x = 45, y = 56, z;
            z = x + y;
            Console.WriteLine($"Add is {z}");
        }
        public void Sub()  // Non Parametrized method   
        {
            int x = 45, y = 56, z;
            z = x - y;
            Console.WriteLine($"Sub is {z}");
        }

        public void Mul(int x, int y)  // parametrized method
        {
            int z;
            z = x * y;
            Console.WriteLine($"Mul is {z}");
        }

        public void Div(int x = 12, int y = 2)  // parametrized method
        {
            int z;
            z = x / y;
            Console.WriteLine($"Div is {z}");
        }

        public void Test(string Name, params string[] Add)
        {
            Console.WriteLine($"name is {Name} & Address is {Add[0]}");
        }

        public int Addition()
        {
            int x = 4, y = 45, z;
            z = x + y;
            Console.WriteLine("Add is from Int return:" + z);
            return z;
        }

        //public void Test() {
        //    return 12;
        //}

        public string Test1()
        {

            Static obj = new Static();
            obj.M1();
            return "Test";
        }   

        public float Test2()
        {
            return 12.34f;
        }   

        public char Test3()
        {
            return 'A';
        }       
    }
}
