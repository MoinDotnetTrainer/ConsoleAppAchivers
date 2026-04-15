

using System.Net.Http.Headers;  //predefine namespace
using ClassLibrary1; //userdefine namespace
using ClassLibraryAchivers;

using MyData;


namespace ConsoleAppAchivers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MyClass1 obj = new MyClass1();
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

            // ConstrExample obj = new ConstrExample(4);

            // Parent p = new Parent();
            // p.Add();
            // p.Sub();

            // Child c = new Child();
            // c.Mul();
            // c.Div();
            // c.Add();
            // c.Sub();

            // Class2 c2= new Class2();

            //EmployeeDetailsAdminDept c = new EmployeeDetailsAdminDept();
            //c.EmpCount();
            //c.Salary();
            //c.Projects();

            // BMW1 b1 = new BMW1();
            // b1.Break(); // p or c

            //Products p = new Products();
            //p.ProductPrice();
            //p.ProductDetails();


            //Orders o = new Orders();
            //o.OrdersPrice();
            //o.OrderDetails(12,2);  // ANother class with static method and this keyword to acheive extension method

            //OrderExten.OrderDetails(o, 12, 2); // we can also call the static method of another class by passing the object as parameter

            // CalbyValRef obj = new CalbyValRef();
            //int res = obj.Data1();
            //int result = obj.Data2();

            //(int x, string y) = obj.Data3();
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //obj.Cal(12, 2, out int Sum, out int Sub);
            //Console.WriteLine(Sum);  // 14
            //Console.WriteLine(Sub); //10

            //   obj.Exe();

            //Excep obj = new Excep();
            //obj.RunTimeError();



            //try
            //{
            //    Prop obj = new Prop();
            //    obj.x_ = 34;
            //    obj.y_ = 34;  // no Seciurity
            //    obj.Add();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////p150 p2 50 = 100


            //AccProject acc = new AccProject();
            //acc.Loreal();

            //Mobile m = new Mobile();
            //m.MobileData();

            /* GenMethods obj = new GenMethods();
             obj.Test(2,2);
             obj.Test(234.45,45.45m);
             obj.Test("hi", "tets");

             obj.Test(45,45);
             obj.GetData<int>(345);
             obj.GetData<string>("hi");
             obj.GetData<bool>(true);

             obj.GetData<int, int>(45,45);
             obj.GetData<int,string>(34,"hi");

             obj.GetResults<int, string, bool>(345,"hi",true);

             GenClass1<int, int> g = new GenClass1<int, int>();
             g.Gen(34,45);
             g.Gen1(34,45);
             g.Gen2("hi","w4");

             GenClass1<int, string> g1 = new ConsoleAppAchivers.GenClass1<int,string>();
             g1.Gen(345,"");
            */

            // Collections obj = new Collections();
            //obj.HoldEmpData();


            /* // single cast
             DelegatesExample obj = new DelegatesExample();
             Cal1 d1 = new Cal1(obj.Add);
             d1.Invoke();
             Cal1 d2 = new Cal1(obj.Sub);
             d2.Invoke();

             // single instace of dele invoking signle method

             Cal2 d3 = new Cal2(DelegatesExample.mul);
             d3.Invoke(34,45);
             Cal2 d4 = new Cal2(DelegatesExample.Div);
             d4.Invoke(34,45);

             // multi cast

             Cal1 d5 = new Cal1(obj.Add);
             d5 += new Cal1(obj.Sub);
             d5.Invoke();


             Cal2 d6 = new Cal2(DelegatesExample.mul);
             d6 += new Cal2(DelegatesExample.Div);
             d6.Invoke(34,4);

             */
            /*// Add method will be called
             Cal1 d2 = new Cal1(obj.Sub);
             d2.Invoke();  // Sub method will be called
             Func<int, int, int> d3 = new Func<int, int, int>(obj.mul);
             int res = d3.Invoke(34, 45);  // Mul method will be called
             Console.WriteLine(res);
             Func<int, int, int> d4 = new Func<int, int, int>(obj.Div);
             int result = d4.Invoke(34, 45);  // Div method will be called
             Console.WriteLine(result);
            */

            /*
            test t = delegate ()
            {
                Console.WriteLine("print data");
            };
            t.Invoke();


            test t1 = () =>
            {
                Console.WriteLine("unnamemethod");
            };
            t1.Invoke();
            */

            // test1 is having
            /*
                        test1 t2 = delegate (int x, int y)
                        {
                            Console.WriteLine("print data1");
                            return x + y;
                        };
                        t2.Invoke(23, 43);


                        test1 t3 = (int x, int y) =>
                        {
                            Console.WriteLine("unnamemethod1");
                            return x + y;
                        };
                        t3.Invoke(24, 45);

                        */

            //   WordCount obj = new WordCount();
            // obj.Exe();

            //Task t = new Task(obj.Exe1);
            //t.Start();
            //t.Wait();
            //Console.ReadLine();

            LINQTutoriuals.Test();


        }
    }
}
