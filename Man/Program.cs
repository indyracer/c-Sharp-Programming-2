using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of base class
            Man henry = new Man();

            //instance of derived class
            Hombre enrique = new Hombre();

            //call  simple method inherited by instance from base class
            henry.speak();

            //call to overloaded method inherited from base class
            henry.speak("It's a beautiful evening");

            //call to hiding method in derived class
            enrique.speak("Hola...");

            //explicit cast to explicitly call overloaded method in base class
            ((Man)enrique).speak("Es una tarde hermosa");

            Console.ReadKey();
        }
    }

    //base class
    public class Man
    {
        public void speak()
        {
            Console.WriteLine("Hello: ");
        }

        public void speak (string message)
        {
            Console.Write(message + "!\n");
        }
    }

    //derived class, method intentionally hides overloaded method from base class
    public class Hombre : Man
    {
        public new void speak(string message)
        {
            base.speak();
            Console.WriteLine(message);
        }
    }
}
