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
            string[] numArray;

            //  If the file doesn't exist
            //      Create a random set of values to populate the initial array
            //  Else
            //      Parse the file, make sure all strings are 3 length
            //      Populate the array with the parsed values

            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"{args[0]} doesn't exist, creating new numbers");
                numArray = RandomNumberGenerator.Generate(10);
            } else
            {
                Console.WriteLine($"{args[0]} exists");
                numArray = ParseFillNumberArray.Fill(args[0]);
            }

            
            //  Print all values from initial array.
            foreach (var val in numArray)
            {
                Console.WriteLine(val);
            }
        }
    }
}
