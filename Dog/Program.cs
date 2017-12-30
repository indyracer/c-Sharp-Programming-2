using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog fido = new Dog();

            //initialize all properties of fido
            fido.setValues("Fido", "Brown", 1);

            //retrieve all properties of new object
            string tagF = String.Format("{0} is a {1} year old {2} dog",
                fido.getName(), fido.getAge(), fido.getColor());

            //display all properties and call bark method
            Console.WriteLine(tagF + fido.bark());

            //create another instance of Dog
            Dog lucy = new Dog();
            lucy.setValues("Lucy", "Gray", 2);

            //retrieve all properties of Lucy
            string tagL = String.Format("{0} is a {1} year old {2} dog",
                lucy.getName(),
                lucy.getAge(),
                lucy.getColor());

            //display all Lucy properities and call bark
            Console.WriteLine(tagL + lucy.bark());
            Console.ReadKey();
        }
    }
    public class Dog
    {
        //variable members
        private string name;
        private string color;
        private int age;

        //setter method for all variables
        public void setValues(string name, string color, int age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
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

        //method for bark
        public string bark()
        {
            return "\nWoof, woof!\n";
        }
    }
}
