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

            int[] numArray;

            if (!File.Exists("testvalues.txt"))
            {
                Console.WriteLine("testvalues.txt doesn't exist, creating new numbers");
                Int32.TryParse(args[0], out int arrayLength);
                numArray = RandomNumberGenerator.Generate(arrayLength);       //int[] numArray = new int[arrayLength];
            } else
            {
                Console.WriteLine("testvalues.txt exists");
                int arrayLength = File.ReadLines("testvalues.txt").Count();
                numArray = new int[arrayLength];
                numArray = Int32.TryParse(File.ReadLines("testvalues.txt").ToString, out int values);

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
