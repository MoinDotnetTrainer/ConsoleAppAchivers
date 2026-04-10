using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class Nullables
    {
        public void TestNullable()
        {
            // value type datatype

            int? x = null;
            float? f = null;
            double? d = null;

            Nullable<int> x1 = null;


            // ref type data type
            string str = null;
            int[] arr = null;

            // boxing value type to ref type
            // & UnBoxing ref type to value is uNboxing

            int res = 34;
            string str_ = res.ToString();  // Boxing
            int mydata = Convert.ToInt16(str_);  // Unboxing

            // Implict & Explict TYpe casting
            // Lower to Higher is Implict

            byte b = 255;
            int b1 = b; // implict  /
            Console.WriteLine(b1);
            sbyte sb = (sbyte)b1;  //explict  we may loose data
            Console.WriteLine(sb); // -128,+127

        }
    }
}
