using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of Cat
            Cat tigger = new Cat();

            //retrieve instance of tigger
            string tagT = String.Format("{0} is a {1} year old {2} cat",
                tigger.getName(),
                tigger.getAge(),
                tigger.getColor());

            Console.WriteLine(tagT + tigger.cry());

            //create new instance of a Cat
            Cat smokey = new Cat();

            //set new properties of Cat for Smokey
            smokey.setName("Smokey");
            smokey.setAge(2);
            smokey.setColor("Gray");

            //retrieve Smokey properties
            string tagS = String.Format("{0} is a {1} year old {2}",
                smokey.getName(),
                smokey.getAge(),
                smokey.getColor());

            //display Smokey properties and call cry method
            Console.WriteLine(tagS + smokey.cry());
            Console.ReadKey();



        }

        public class Cat
        {
            private string name, color;
            private int age;

            //class constructor
            public Cat()
            {
                name = "Tigger";
                age = 3;
                color = "Brown";
            }

            //setter methods for each variable
            public void setName(string name)
            {
                this.name = name;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public void setColor(string color)
            {
                this.color = color;
            }

            //getter methods for each variable
            public string getName()
            {
                return name;
            }

            public string getColor()
            {
                return color;
            }

            public int getAge()
            {
                return age;
            }

            //cry method
            public string cry()
            {
                return "\nMeow, Meow!\n";
            }
        }
    }
}

