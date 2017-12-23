using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Joined";

            //create and initialize string array
            string[] a = new string[3] { "Alpha", "Bravo", "Charlie" };

            //concatenated version of first 2 array elements
            string s = string.Concat(a[0], a[1]);
            Console.WriteLine("Concatenated:\t" + s);

            //joined version of first two array elements and space separator
            s = String.Join(" ", a[0], a[1]);
            Console.WriteLine("Joined:\t\t" + s);

            //joined version of all three elements, tag separator
            s = String.Join("<br>", a[0], a[1], a[2]);
            Console.WriteLine("\nHTML:\t" + s + "\n");

            //compare all 3 elements for alphabetic order
            int num = String.Compare(a[0], a[1]);
            Console.WriteLine(a[0] + " v " + a[1] + "\t\t" + num);

            num = String.Compare(a[1], a[2]);
            Console.WriteLine(a[2] + " v " + a[1] + "\t\t" + num);

            //test array elements for equality
            bool flag = (a[0] == a[1]);
            Console.WriteLine(a[0] + " == " + a[1] + ":\t\t" + flag);
            flag = a[2].Equals(a[2]);
            Console.WriteLine(a[2] + " == " + a[2] + ":\t" + flag);
            Console.ReadKey();
        }

    }

}
