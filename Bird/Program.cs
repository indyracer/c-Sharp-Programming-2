using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
    class Program
    {
        static void Main(string[] args)
        {

            //instances of non base class
            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();

            //call appropriate methods
            describe(joey);
            describe(lola);

            Console.ReadKey();
        }

        //methods to call overriding methods
        static void describe(Bird obj)
        {
            obj.talk();
            obj.fly();
        }
    }

    //bass class, with 2 methods that allow overriding
    public class Bird
    {
        public virtual void talk()
        {
            Console.WriteLine("A Bird Talks...");
        }

        public virtual void fly()
        {
            Console.WriteLine("A Bird Flies...\n");
        }
    }

    //derived class  with 2 methods that will override base class methods
    public class Pigeon : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Pigeon Says:  Coo! Coo!");
        }

        public override void fly()
        {
            Console.WriteLine("A Pigeon Flies Away...");
            base.fly();
        }
    }

    //derived class that will also override base class methods
    public class Chicken : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Chicken Says:  Cluck! Cluck!");
        }

        public override void fly()
        {
            Console.WriteLine("I'm a Chicken - I Can't Fly!");
            base.fly();
        }
    }
}
