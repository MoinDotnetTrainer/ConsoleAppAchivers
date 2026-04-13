using System.Net.Http.Headers;

namespace ConsoleAppAchivers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Test");
            //Console.WriteLine("We are ABout to Start C#");

            //System.Console.WriteLine("test");

            //Demo obj = new Demo();
            //obj.Add();

            //  DataTypes obj = new DataTypes();
            // obj.TestDataTypes();

            //  ReadLineEx obj = new ReadLineEx();
            //  obj.ReadLineMethod();

            //  Parsing parsing = new Parsing();
            //  parsing.ParsingMethod();

            ///  Nullables obj = new Nullables();
            //  obj.TestNullable();

            /* ClassExample obj = new ClassExample();
             obj.Add();
             obj.Sub();
             obj.Mul(243, 3);

             obj.Mul(y: 34, x: 2);   // Named Arguments
             obj.Div();

             obj.Test("Test", "Hyd");
             int myres = obj.Addition();  // myres = z
             if (myres == 49)
             {
                 Console.WriteLine("do this");
             }
             else
             {
                 Console.WriteLine("do that");
             }

             */

            //Static obj = new Static();
            //obj.M1();
            //Static.M2();
            //Static.M3();

            //StaticClass.M1();
            //StaticClass.M2();
            //StaticClass.M3();   

            //  MethodOverload obj = new MethodOverload();
            // obj.Task("Batting",35);

            //  Console.WriteLine(true);

            //   ConstrOverload obj = new ConstrOverload(34,45);  // manualyy explc
            //  
            // StaticConstrExample.DisplayMessage();

            ConstrExample obj = new ConstrExample(4);
        }
    }
}
