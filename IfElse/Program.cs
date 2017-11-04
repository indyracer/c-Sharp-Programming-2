using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "IfElse";

            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thanks. Now enter a letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            //output message if number input exceeds specified value
            if(num >= 6)
            {
                Console.WriteLine("\nNumber exceeds 5");
                //Nested statement to check if letter is specified value
                if(letter == 'C')
                {
                    Console.WriteLine("Letter is 'C'");
                }
            }
            else
            {
                Console.WriteLine("\nNumber is 5 or less");
            }

            Console.ReadKey();
        }
    }
}
