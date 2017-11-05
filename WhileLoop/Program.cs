﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WhileLoop";

            int[] nums = new int[10];
            int i = 0;

            //while loop
            while (i < nums.Length)
            {
                nums[i] = i;
                Console.Write(" | " + nums[i]);
                i++;
            }
            Console.Write("\n\n");

            //do while looop
            do
            {
                i--;
                //skip a single step
                if (i == 8)
                {
                    Console.Write(" | Skipped");
                    continue;
                }
                //Exite loop
                if(i == 3)
                {
                    Console.Write(" | Done");
                    break;
                }
               
                Console.Write(" | " + nums[i]);
            }
            while (i > 0);
            Console.ReadKey();
        }
    }
}
