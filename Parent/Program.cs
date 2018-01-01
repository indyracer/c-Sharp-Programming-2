using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parent
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instances of derived classes
            Daughter anna = new Daughter();
            Son brad = new Son();
            Son carl = new Son(100);
            Console.ReadKey();
        }
    }

    //base class
    public class Parent
    {
        //constructor
        public Parent()
        {
            Console.WriteLine("Parent Called");
        }

        //overloaded constructor
        public Parent(int num)
        {
            Console.WriteLine("Parent + Called: " + num);
        }
    }

    //derived class Daughter
    public class Daughter : Parent
    {
        public Daughter()
        {
            Console.WriteLine("\tDaughter Called\n");
        }
    }

    //derived class Son
    public class Son : Parent
    {
        public Son()
        {
            Console.WriteLine("\tSon Called\n");
        }

        //overloaded constructor
        public Son(int num) : base(num)
        {
            Console.WriteLine("\tSon + Called: " + num);
        }
    }
}
