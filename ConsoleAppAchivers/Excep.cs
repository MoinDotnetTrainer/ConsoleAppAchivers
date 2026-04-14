using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class Excep
    {
        public void RunTimeError()
        {
        a:
            try
            {
                Console.WriteLine("Enter x");
                int x = Convert.ToInt32(Console.ReadLine());  // Error
                Console.WriteLine("Enter Y");
                int y = Convert.ToInt32(Console.ReadLine()); // Error
                int z = x / y;  // if y is 0 then we will get an error
                Console.WriteLine("z:" + z);

                int[] arr = { 23};
                Console.WriteLine(arr[10]);  // runtime , we need to under

                string str = null;
                int x1 = str.Length; // Null Reference Exception    
            }
           
            catch (FormatException ex)  // root class for all exceptions
            {
                Console.WriteLine("Plz Chk ur Imput:" + ex.Message);
                goto a;
            }
            catch (DivideByZeroException ex)  // root class for all exceptions
            {
                Console.WriteLine("Plz Chk ur Input,Y cannot be a zero:" + ex.Message);
                goto a;
            }
            catch (Exception ex)  // root class for all exceptions
            {
                Console.WriteLine("Plz Chk ur Imput:" + ex.Message);
                goto a;
            }


        }
    }
}
