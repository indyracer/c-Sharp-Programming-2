using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Substring";

            //initialize a string variable, display it and its length
            string text = "My dog is a cute dog";
            Console.WriteLine(text + "\tLength: " + text.Length);

            //request user input to intialize another variable with a substring to seek
            Console.WriteLine("\nPlease enter a Substring to seek: ");
            string sub = Console.ReadLine();

            //create a character array and copy entire substring into the array
            char[] arr = new char[sub.Length];
            sub.CopyTo(0, arr, 0, sub.Length);

            //seek first occurance of substring and call method to report results
            int pos = text.IndexOf(sub);
            report(pos, sub);

            //seek last occurance of substring and report result
            pos = text.LastIndexOf(sub);
            report(pos, sub);

            //seek first occurrence of any character of substring and report result
            pos = text.IndexOfAny(arr);
            report(pos, text.Substring(pos, 1));

            //seek the last occurrence of any character of the substring and report result
            pos = text.LastIndexOfAny(arr);
            report(pos, text.Substring(pos, 1));
            Console.ReadKey();
        }

        //method to report result of substring search
        static void report (int pos, string sub)
        {
            if(pos != -1)//-1 indicates no match found
            {
                Console.WriteLine("'" + sub + "' Found at " + pos);
            }
            else
            {
                Console.WriteLine("'" + sub + "' Not Found!");
            }
        }
    }
}
