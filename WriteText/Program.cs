using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WriteText";

            //initialize 2 variables
            string path = "C:\\Users\\Bob\\Desktop\\poem.txt";
            string poem = "\r\n\tI never saw a man who looked";
            poem += "\r\n\tWith such a wistful eye";
            poem += "\r\n\tUpon that little tent of blue";
            poem += "\r\n\tWhich prisoners call the sky";

            //statement to test if file already exists at specified path and filename
            if (File.Exists(path))
            {
                Console.WriteLine("File already exists: " + path);
            }
            else
            //statements that attempt to write a text file and confirm success or failure
            {
                try
                {
                    File.WriteAllText(path, poem);
                    Console.WriteLine("File Written: " + path);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

            }      
            
            Console.ReadKey();
        }
    }
}
