using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Switch";

            Console.Write("Please enter a number between 1 and 7:  ");
            int num = Convert.ToInt16(Console.ReadLine());

            string day;

            switch (num)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "No day like today";
                    break;
            }
            Console.WriteLine("Day " + num + ": " + day);
            Console.ReadKey();
        }
    }
}
