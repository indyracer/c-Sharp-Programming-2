using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Manipulate";

            //request input from user
            Console.WriteLine("Please Enter Text: ");
            string text = Console.ReadLine();

            //statements to display user input string and report length
            Console.Write("\nThanks.  You Entered:\n'" + text + "'");
            Console.WriteLine("\t\tText Length: " + text.Length);

            //remove leading and trailing whitespace, display maniuplated version and report length
            text = text.Trim();
            Console.Write("\nTrimmed:\t'" + text + "'");
            Console.WriteLine("\nText Length: " + text.Length);

            //statements to create and display an uppercase version of trimmed string
            string upper = text.ToUpper();
            Console.WriteLine("\nUpperCase:\t'" + upper + "'");

            //statements to create and display lower case version of trimmed string
            string lower = text.ToLower();
            Console.WriteLine("LowerCase:\t'" + text + "'");

            //manipulate all three strings to add whitespace and character padding
            upper = upper.PadLeft(40);
            lower = lower.PadRight(40, '#');
            text = text.PadLeft(30, '*').PadRight(40, '*');

            //statements to display the 3 strings
            Console.WriteLine("\nPadded Left:\t'" + upper + "'");
            Console.WriteLine("Padded Right:\t'" + lower + "'");
            Console.WriteLine("Padded Both:\t'" + text + "'");

            //statements to display trimmed versions of two padded strings
            Console.WriteLine("\nTrimmed Start:\t'" + upper.TrimStart() + "'");
            Console.WriteLine("Trimmed End:\t'" + text.TrimEnd('*') + "'");

            Console.ReadKey();
        }
    }
}
