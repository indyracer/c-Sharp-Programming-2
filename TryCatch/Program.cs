using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try

    {
                Console.Write("Please Enter a number: ");
                double num1 = Convert.ToInt16(Console.ReadLine());

                Console.Write("Now enter another number: ");
                double num2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Total: " + (num1 + num2));
            }

    catch (OverflowException)
            {

                Console.WriteLine("\nMaximum: " + Int16.MaxValue);
            }

            Console.ReadKey();
        }
    }
}
