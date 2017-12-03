using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Overload";

            double num;
            double area;

            Console.Write("Please Enter Dimension in Feet: ");
            num = Convert.ToDouble(Console.ReadLine());

            area = computeArea(num);
            Console.WriteLine("\nCircle:\t\tArea = " + area + "sq.ft.");

            area = computeArea(num, num);
            Console.WriteLine("Square:\t\tArea = " + area + "sq.ft.");

            area = computeArea(num, num, 'T');
            Console.WriteLine("Triangle:\tArea = " + area + "sq.ft.");

            Console.ReadKey();
        }

        //calculate area of a circle
        static double computeArea(double width)
        {
            double radius = width / 2;
            return ((radius * radius) * 3.141593);
        }

        //calculate area of a square
        static double computeArea(double width, double height)
        {
            return width * height;
        }

        //calculate the area of a triangle, char letter only used to show overload principle
        static double computeArea (double width, double height, char letter)
        {
            return ((width / 2) * height);
        }


    }
}
