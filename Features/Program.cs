using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Features";

            //get input from user
            Console.Write("Please enter text: ");
            string text = Console.ReadLine();

            //test to see that user entered text before enter
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("\nERROR:  No Text Found!");
            }
            else
            {
                //statements to report length
                Console.WriteLine("\nThanks.  You entered:\n'" + text + "'");
                Console.WriteLine("\nText Length: " + text.Length);

                //statement to test how string begins
                string query = text.StartsWith("C#") ? "Does" : "Does Not";
                Console.WriteLine("Text " + query + " Starts with 'C#'");

                //statement to test how string ends
                query = text.EndsWith("steps") ? "Does" : "Does Not";
                Console.WriteLine("Text " + query + " End with 'steps'");

                //statement to test what string contains
                query = text.Contains("easy") ? "Does" : "Does Not";
                Console.WriteLine("Text " + query + " Contain 'easy'");
            }

            Console.ReadKey();
        }

            
    }
}
