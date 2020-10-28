﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace RadixSorting
{
    class Program
    {       /*
            This program will take (or generate) a list of numbers between 0-1000, then use Radix Sort to sort them in ascending order.
            At the end of the sorting, it will show how many steps were taken by the program, allowing it to be compared to other
            sorting methods with a simple value.
            Both Radix Bucket and Radix Counting will be implemented, and either or both can be run.
            */
        static void Main(string[] args)
        {
            List<int[]> intArrayList = new List<int[]>();

            if (args[0] == "rand")
            {
                Console.WriteLine($"Randomising {args[1]} numbers");
                intArrayList = RandomNumberGenerator.Generate(Int32.Parse(args[1]));
            }
            else
            {
                if (File.Exists(args[0]))
                {
                    Console.WriteLine($"{args[0]} exists");
                    intArrayList = ParseFillNumberArray.Fill(args[0]);
                }
                else
                {
                    Console.WriteLine($"{args[0]} doesn't exist");
                }
            }


            //  Print all values from initial array.
            if (intArrayList != null)
            {
                Console.WriteLine("Initial intArray values are:");
                foreach (var val in intArrayList)
                {
                    Console.WriteLine(string.Join("", val));
                }
            }

            //  Begin Radix Sort using the Bucket method
            List<int[]> bucketSortedList = RadixSort.BucketVariant(intArrayList);

            //  Print result
            Console.WriteLine("List has been sorted:");
            foreach (var intArray in bucketSortedList)
            {
                Console.WriteLine(string.Join("", intArray));
            }

            //  Begin Radix Sort using the Counting method
            List<int[]> countingSortedList = RadixSort.CountingVariant(intArrayList);
        }
    }
}
