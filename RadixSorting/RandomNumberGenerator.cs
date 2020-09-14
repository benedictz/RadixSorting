using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadixSorting
{
    class RandomNumberGenerator
    {
        /// <summary>
        /// Creates a list of values between 0 and 1000 (non-inclusive) and parsing them to have 3 digits. Returns these values as a string array.
        /// </summary>
        /// <param name="arrayLength">The amount of values to create in the array.</param>
        /// <returns></returns>
        static public string[] Generate(int arrayLength)
        {
            string[] numList = new string[arrayLength];

            Random rnd = new Random();
            for (int i = 0; i < numList.Length; i++)
            {
                string newNum = rnd.Next(0, 1000).ToString();
                if (newNum.Length < 3)
                {
                    for (int j = 0; j < 3 - newNum.Length; j++)
                    {
                        newNum = "0" + newNum;
                    }
                }
                numList[i] = newNum;
            }

            return numList;
        }
    }
}
