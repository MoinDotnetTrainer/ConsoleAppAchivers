using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class DataTypes
    {
        public void TestDataTypes()
        {

            // only +ve unSigned 1 byte = 8 bits    0-255
            byte b = 4;  // 100 time--> 4
            byte b1 = 255;
            byte b2 = 0;
            byte b3 = 45;

            // +- Value sbyte  Signed
            sbyte sb = -34;
            sbyte sb1 = -128;
            sbyte sb2 = 127;
            sbyte sb3 = 35;
            Console.WriteLine(b);
            Console.WriteLine(b1);

            Console.WriteLine(sb);
            Console.WriteLine(sb1);

            float f = 34.5f;
            double d = 45.56;
            decimal dm = 45.45m;

            bool status = true;
            bool isCompleted = false;

            string str = "Hello World";
            string Email = "xyz@yahoo.com";
            string password = "3445hgfh!@#$$";

            char c = 'A'; // Initials

            // other 
            // Var , dynamic & object
            //  can takes any type of value


            // compile time type checking   
            var v1 = 4;
            v1 = 67;
            v1 = 456;
            v1 = 46;
          //  v1 = 34.456;  //error here


            var v2 = 234.3546;
            var v3 = "Hello";
            var v4 = true;
            v4 = false;


            // runtime , during the prog exe
            dynamic d1 = 4;
            d1 = 45.56;
            d1 = "Hello";


            dynamic d2 = 234.3546;
            dynamic d3 = "Hello";
            dynamic d4 = true;

            // value type
            dynamic res = d1 + d2;


            // ref type
            object o1 = 4;
            o1 = 45.56;
            o1 = "Hello";

            object o2 = 234.3546;
            object o3 = "Hello";
            object o4 = true;

            object result = (int)o1 + (int)o2;

            // string gas to be converted into number


            // A+b=c
            // 1+2=3
        }
    }
}
