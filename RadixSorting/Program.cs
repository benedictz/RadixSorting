﻿using System;
using System.IO;
using System.Linq;

namespace RadixSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //  This program will generate a list of numbers, then use Radix Sort to sort them in ascending order.
            //  At the end of the sorting, it will show how many steps were taken by the program, allowing it to be
            //  compared to other sorting methods with a simple value.
            //  Both Radix Bucket and Radix Counting will be implemented, and either or both can be run.

            //  Create array for the initial values
            string[] numArray = null;

            //  If arguments are "rand" and a number
            //      Generate that amount of random numbers
            //  If file exists
            //      Parse that file

            if (args[0] == "rand")
            {
                Console.WriteLine($"Randomising {args[1]} numbers:");
                numArray = RandomNumberGenerator.Generate(Int32.Parse(args[1]));
            }
            else
            {
                if (File.Exists(args[0]))
                {
                    Console.WriteLine($"{args[0]} exists:");
                    numArray = ParseFillNumberArray.Fill(args[0]);
                }
                else
                {
                    Console.WriteLine($"{args[0]} doesn't exist");
                }
            }


            //  Print all values from initial array.
            if (numArray != null)
            {
                foreach (var val in numArray)
                {
                    Console.WriteLine(val);
                }
            }
        }
    }
}
