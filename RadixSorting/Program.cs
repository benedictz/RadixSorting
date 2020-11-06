using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace RadixSorting
{
    /*
    This program will take (or generate) a list of numbers between 0-1000, then use Radix Sort to sort them in ascending order.
    At the end of the sorting, it will show how many steps were taken by the program, allowing it to be compared to other
    sorting methods with a simple value.
    Both Radix Bucket and Radix Counting will be run, with the results compared against each other.
    */
    class Program
    {
        static List<int[]> fileCheck(string input)
        {
            List<int[]> intArray = new List<int[]>();
            if (File.Exists(input))
            {
                Console.WriteLine($"{input} exists");
                intArray = ParseFillNumberArray.Fill(input);
            }
            else
            {
                Console.WriteLine($"'{input}' doesn't exist.");
            }
            return intArray;
        }

        static void Main(string[] args)
        {
            List<int[]> intArrayList = new List<int[]>();
            string input;
            bool exit = false;

            while (!exit)
            {
                switch (args.Count()) {
                    case 0:     //  User has input nothing, provide options
                        Console.WriteLine("Pick one of the following:\n'10nums.txt' for 10 set numbers\n'100nums.txt' for 100 set numbers\n'1000nums.txt' for 1000 set numbers\n'rand' for randomised numbers\n'exit' to end the program");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "rand":
                                Console.WriteLine("How many numbers would you like to generate?");
                                intArrayList = RandomNumberGenerator.Generate(Int32.Parse(Console.ReadLine()));
                                break;
                            case "exit":
                                exit = true;
                                break;
                            default:
                                intArrayList = fileCheck(input);
                                break;
                        }
                        break;
                    case 1:     //  User has input a single option, likely a filename or rand
                        if (args[0] == "rand")
                        {
                            Console.WriteLine("How many numbers would you like to generate?");
                            intArrayList = RandomNumberGenerator.Generate(Int32.Parse(Console.ReadLine()));
                        } else
                        {
                            intArrayList = fileCheck(args[0]);
                        }
                        break;
                    case 2:     //  User has input two options, likely 'rand #'
                        intArrayList = RandomNumberGenerator.Generate(Int32.Parse(args[1]));
                        break;
                    default:    //  Too many options
                        Console.WriteLine($"This doesn't seem right, why are there {args.Count()} arguments?");
                        exit = true;
                        break;

                }

                if (intArrayList.Count > 0)
                {
                    //  Begin Radix Sort using the Bucket method
                    Stopwatch bucketWatch = Stopwatch.StartNew();
                    List<int[]> bucketList = RadixSort.BucketVariant(intArrayList);
                    bucketWatch.Stop();
                    Console.WriteLine($"Bucket Variant took {bucketWatch.ElapsedTicks} ticks to complete");

                    //  Begin Radix Sort using the Counting method
                    Stopwatch countWatch = Stopwatch.StartNew();
                    List<int[]> countList = RadixSort.CountingVariant(intArrayList);
                    countWatch.Stop();
                    Console.WriteLine($"Counting Variant took {countWatch.ElapsedTicks} ticks to complete");

                    //  Request to show sorted numbers
                    Console.WriteLine($"Would you like to display the {intArrayList.Count()} values? y/n");
                    input = Console.ReadLine().ToLower();
                    if (input == "y" || input == "yes")
                    {
                        //  Print all lists
                        Console.WriteLine("InitialList\tBucketList\tCountList");
                        for (int i = 0; i < intArrayList.Count(); i++)
                        {
                            Console.WriteLine($"{string.Join("", intArrayList[i])}\t\t{string.Join("", bucketList[i])}\t\t{string.Join("", countList[i])}");
                        }
                    }
                    exit = true;
                }
            }
        }
    }
}
