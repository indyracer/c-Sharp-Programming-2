using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Format";

            //initialize numeric value, output as currency
            double sum = 2500;  //needs to be a double in order for precent and fix zero padded to work
            Console.WriteLine("Currency String: " + sum.ToString("C"));

            //use String.Format() method to output sum in various formats
            Console.Write(String.Format("\nGeneral:\t {0:G}", sum));
            Console.Write(String.Format("\nFixed Point:\t {0:F2}", sum)); //need to specify the number of decimal places
            Console.Write(String.Format("\nNumber:\t\t {0:N}", sum));
            Console.Write(String.Format("\nCurrency:\t {0:C}", sum));

            //reduce numeric value and output it in precentage format with padded zeros
            double percent = sum / 1000;
            Console.Write(String.Format("\nPercentage:\t {0:P2}", percent));
            Console.Write(String.Format("\nZero Padded:\t {0:00.00000} \n", percent));

            //create comma seperated string list and split into individual elements of string array for output
            string data = "Mike,McGrath,Author";
            string[] items = data.Split(',');
            foreach (string item in items)
            {
                Console.Write(String.Format("\n* {0}", item));
            }

            Console.ReadKey();
        }
    }
}
