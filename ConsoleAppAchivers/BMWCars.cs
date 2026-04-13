using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    internal class BMWCars
    {
        public virtual void Break()
        {
            Console.WriteLine("To stop a car");
        }
        public virtual void Acclelerate()
        {
            Console.WriteLine("To Move");
        }

        public void Engine()
        {
            Console.WriteLine("Engine Capacity");
        }
    }

    class BMW1 : BMWCars
    {
        public new void Break()
        {
            Console.WriteLine("To stop a BMW1 car");  // HYDROLIC BRAKE
        }
        public override void Acclelerate()
        {
            Console.WriteLine("To Move a BMW1");
        }
    }

    class BMW2 : BMWCars
    {
        public override void Break()
        {
            Console.WriteLine("To stop a BMW2 car");  // DISC BRAKE
        }
        public override void Acclelerate()
        {
            Console.WriteLine("To Move a BMW2");
        }
    }


}
