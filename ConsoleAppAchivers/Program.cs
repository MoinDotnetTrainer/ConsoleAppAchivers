

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

            Collections obj = new Collections();
            obj.HoldEmpData();
            
        }
    }
}
