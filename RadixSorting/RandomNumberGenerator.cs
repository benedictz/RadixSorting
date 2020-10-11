using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadixSorting
{
    class RandomNumberGenerator
    {
        /// <summary>
        /// Creates a list of values between 0 and 1000 (non-inclusive) and parsing them to have 3 digits. Returns these values as a List of char arrays.
        /// </summary>
        /// <param name="arrayLength">The amount of values to create in the array.</param>
        /// <returns></returns>
        static public List<char[]> Generate(int arrayLength)
        {
            List<char[]> charList = new List<char[]>();

            Random rnd = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                string newNum = rnd.Next(0, 1000).ToString();
                if (newNum.Length < 3)  
                {
                    for (int j = 0; j < 3 - newNum.Length; j++)
                    {
                        newNum = "0" + newNum;
                    }
                }

                char[] currentChar = newNum.ToCharArray();
                charList.Add(currentChar);
            }

            //  Obviously this creates the hard limit threshold of 3 digits per number, or a max value of 999.
            //  Maybe I can rejig this logic later to dynamically scale based on input?

            return charList;
        }
    }
}
