using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DateFormat";

            //initialize DateTime object
            DateTime now = DateTime.Now;
            Console.Write("Current date and time: " + now);

            //specify components fo DateTime object
            Console.Write("\nDay Name: " + now.DayOfWeek);
            Console.Write("\nDate only: " + now.ToShortDateString());
            Console.Write("\nTime only: " + now.ToLongTimeString());

            //modify DateTime and display new value
            now = now.AddYears(4);
            Console.Write("\n\nFuture Date: " + now);

            //creat new DateTime object and display it
            DateTime dt = new DateTime(2017, 7, 4, 8, 15, 30);
            Console.Write("\n\nSet Date and Time : {0:f}", dt);

            //Display specific components of object
            Console.Write("\nDay Name: {0:dddd}", dt);
            Console.Write("\nLong Date: {0:D}", dt);
            Console.Write("\nLong Time: {0:T}", dt);
            Console.ReadKey();
        }
    }
}
