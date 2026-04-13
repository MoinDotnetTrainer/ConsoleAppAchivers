using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class ConstrReadonly
    {
        // const & readonly
        // variables

        int x = 56;
        int y;
        const int z = 89;
        // z has been dec , value should be initialized at the time of declaration
        readonly int a ;     // value ini happens only once

        public ConstrReadonly()
        {
            x = 46;
            y = 67;
         //  z = 23;
            a = 5;
        }
        public ConstrReadonly(int x)
        {
            x = 46;
            y = 67;
          //  z = 23;
            a = 534;
        }
        public void Test()
        {
            x = 34;
           
        }

    }
}
