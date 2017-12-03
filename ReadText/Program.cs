using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ReadText";

            //initialize variable
            string path = "C:\\Users\\Bob\\Desktop\\word.txt";

            //test if file already exists
            if (File.Exists(path))
            {
                try
                {
                    //assign text file contents to a variable
                    string text = File.ReadAllText(path);
                    Console.WriteLine("File Read: " + path + "\n");
                    Console.WriteLine(text + "\n");

                    //assign text file contents to array variable and display each element with a counter
                    string[] lines = File.ReadAllLines(path);
                    int num = 1;
                    foreach(string line in lines)
                    {
                        Console.WriteLine(num + " : " + line);
                        num++;
                    }

                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                Console.WriteLine("File Not Found: " + path);
            }
            Console.ReadKey();


        }
    }
}
