﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Method";

            bodyTemp();
            Console.WriteLine("Fahrenheit:\t" + bodyTempF() + "°F");
            Console.WriteLine("Kelvin:\t\t" + bodyTempK() + "K");
            Console.ReadKey();
        }

        static void bodyTemp()
        {
            Console.WriteLine("Body Temperature...");
            Console.WriteLine("Centigrade:\t37°C");
          }

        static double bodyTempF()
        {
            double temperature = 98.6;
            return temperature;
        }

        static int bodyTempK()
        {
            int temperature = 310;
            return temperature;
        }



        }


    }

