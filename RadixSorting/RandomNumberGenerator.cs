using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadixSorting
{
    class RandomNumberGenerator
    {
        /// <summary>
        /// Creates a list of values between 0 and 1000 (non-inclusive) and parsing them to have 3 digits. Returns these values as a list of integer arrays.
        /// </summary>
        /// <param name="listLength">The amount of values to create in the array.</param>
        /// <returns></returns>
        static public List<int[]> Generate(int listLength)
        {
            Console.WriteLine($"Randomising {listLength} numbers");
            List<int[]> numList = new List<int[]>();

            Random rnd = new Random();
            for (int i = 0; i < listLength; i++)
            {
                int randNum = rnd.Next(1000);
                int[] numArray = ToIntArray.Convert(randNum);
                numList.Add(numArray);
            }

            return numList;
        }
    }
}
