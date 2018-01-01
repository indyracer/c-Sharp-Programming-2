using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of Rectangle and Triangle
            Rectangle rect = new Rectangle();
            Triangle cone = new Triangle();

            //set values via inherited setter method
            rect.setValues(4, 5);
            cone.setValues(4, 5);

            //call area methods from derived class and display values
            Console.WriteLine("Rectangle Area: " + rect.area());
            Console.WriteLine("Triangle Area: " + cone.area());
            Console.ReadKey();
        }
    }

    //base class
    public class Polygon
    {
        protected int width, height;

        public void setValues(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }

    //defines class derived from base Polygon
    public class Rectangle : Polygon
    {
        public int area()
        {
            return width * height;
        }
    }

    //defines another class derived from base Polygon
    public class Triangle : Polygon
    {
        public int area()
        {
            return (width * height) / 2;
        }
    }
}
