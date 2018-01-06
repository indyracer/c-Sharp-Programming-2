using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppendText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AppendText";

            //initialize statements
            string path = "C:\\Users\\Bob\\Desktop\\oscar.txt";
            string[] poem = new string[]
            {
                "\tIn Debtors' Yard the stones are hard",
                "\tAnd the dripping wall is high"
            };
            string attrib = "\r\nThe Ballad of Reading Goal ";
            attrib += "(Oscar Wilde 18989)";

            //statement to test if file already exists in specified path and file name
            if (File.Exists(path))
            {
                File.AppendAllText(path, attrib);
                Console.WriteLine("Append To File " + path);
            }
            else
            {
                try
                {
                    File.WriteAllLines(path, poem);
                    Console.WriteLine("File Written " + path);
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
