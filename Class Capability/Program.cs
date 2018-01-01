using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Capability
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instances of non-base class objects
            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();
            Caller call = new Caller();

            call.describe(joey);
            call.describe(lola);
            Console.ReadKey();
        }
    }

    //base class with 2 methods
    public abstract class Bird
    {
        public abstract void talk();
        public abstract void fly();
    }

    //derived class with 2 methods that over ride base class methods
    public sealed class Pigeon : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Pigeo Says: Coo! Coo!");
        }

        public override void fly()
        {
            Console.WriteLine("A Pigeon Flies Away...");
        }
    }

    //derived class with 2 methods that over ride base class methods
    public sealed class Chicken : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Chicken Says:  Cluck! Cluck!");
        }

        public override void fly()
        {
            Console.WriteLine("I'm A Chicken - I Can't Fly!");
        }
    }

    //class containing a single method that accepts object arguement
    public sealed class Caller
    {
        public void describe(Bird obj)
        {
            obj.talk();
            obj.fly();
        }
    }
}
