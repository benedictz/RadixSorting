using System;
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
            int[] numArray;

            //  If the file doesn't exist
            //      Create a random set of values to populate the initial array
            //  Else
            //      Parse the file
            //      Populate the array with the parsed values

            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"{args[0]} doesn't exist, creating new numbers");
                numArray = RandomNumberGenerator.Generate(10);
            } else
            {
                Console.WriteLine($"{args[0]} exists");
                int arrayLength = File.ReadLines(args[0]).Count();
                numArray = new int[arrayLength];
                //numArray = Int32.TryParse(File.ReadLines("testvalues.txt").ToString(), out int values);

                for (int i = 0; i < arrayLength; i++)
                {
                    //numArray[i] = File.
                }
            }

            

            /*foreach (int val in numArray)
            {
                Console.WriteLine(val);
            }*/
        }
    }
}
