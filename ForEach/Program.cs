﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ForEach";

            string[] websites = new string[5] { "google", "youTube", "Facebook", "Baidu", "Yahoo" };

            Console.WriteLine("Popular websites...");

            int rank = 1;
            foreach( string site in websites)
            {
                Console.WriteLine("Position: " + rank + "\t" + site);
                rank++;
            }

            Console.ReadKey();
        }
    }
}
