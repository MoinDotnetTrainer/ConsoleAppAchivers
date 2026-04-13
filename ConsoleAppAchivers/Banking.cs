using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    abstract class Banking // sector
    {
        public abstract void WithDraw(); //get money  // no implementation, only declaration 
        public abstract void Deposit();  // put money
        public abstract void Cheques();  // deposite chequw

    }

    class SBI : Banking
    {
        public override void WithDraw()
        {
            Console.WriteLine("SBI with draw");
        }
        public override void Deposit()
        {
            Console.WriteLine("SBI deposit");
        }
        public override void Cheques()
        {
            Console.WriteLine("SBI cheques");
        }
    }   

    abstract class Vehicle
    {
        public abstract void Break();  // to stop // no implementation, only declaration  
        public abstract void Acclelerate();
    }

    class Car : Vehicle
    {
        public override void Break()
        {
            Console.WriteLine("To stop a car");
        }
        public override void Acclelerate()
        {
            Console.WriteLine("To Move");
        }
    }
     class Bike : Vehicle
    {
        public override void Break()
        {
            Console.WriteLine("To stop a bike");
        }
        public override void Acclelerate()
        {
            Console.WriteLine("To Move a bike");
        }
    }   
}
