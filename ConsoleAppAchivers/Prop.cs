using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class Prop
    {
        private int x;

        public int x_
        {
            get { return x; }
            set {

                if (value > 50)
                {
                    throw new ArgumentOutOfRangeException("Value cannot more than 50");
                }
                else
                {

                    x = value;
                }
            }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set
            {
                if (value > 50)
                {
                    throw new ArgumentOutOfRangeException("Value cannot more than 50");
                }
                else
                {

                    y = value;
                }
            }
        }


        public int x1 { get; set; }  // x1 is prop
        public void Add()
        {
            int z = x + y;
            Console.WriteLine("z:" + z);
        }

    }

    class Prop1 : Prop
    {
        //public void Data()
        //{
        //    x = 45;  
        //    y = 56;
        //    z = x + y;
        //}
    }

}
