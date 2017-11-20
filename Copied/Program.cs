using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copied
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Copied";

            string car1 = "Ghibli";
            string car2 = "GranTurismo";

            //display original values
            Console.WriteLine("Original:");
            Console.WriteLine("\tCar1: " + car1 + "\t\tCar 2: " + car2);

            //copy value of second string into first string
            car1 = String.Copy(car2);
            Console.WriteLine("\nCopied:");
            Console.WriteLine("\tCar 1: " + car1 + "\tCar 2: " + car2);

            //initialize variable with length of first string variable, cre0ate character array of that length
            int num = car1.Length;
            char[] model = new char[num];

            //copy first string variable int character array
            car1.CopyTo(0, model, 0, num);
            Console.WriteLine("\nCharacter Array:");
            foreach(char c in model)
            {
                Console.Write(c + " ");
            }

            //remove the end of the first string variable, starting from 5th element
            car1 = car1.Remove(4);
            Console.WriteLine("\n\nRemoved... \tCar 1: " + car1);

            //insert two strings into the first string variable, at beginning and end.
            car1 = car1.Insert(0, "Maserati ");
            car1 = car1.Insert(13, "Cabrio");
            Console.WriteLine("\nInserted...\tCar 1: " + car1);

            //replace a substring within the first string variable
            car1 = car1.Replace("GranCabrio", "Quattroporte");
            Console.WriteLine("\nReplaced... \tCar 1: " + car1);
            Console.ReadKey();
        }
    }
}
