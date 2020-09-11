using System;
using System.Collections.Generic;
using System.Text;

namespace RadixSorting
{
    class RandomNumberGenerator
    {
        static public int[] Generate(int arrayLength)
        {
            int[] numList = new int[arrayLength];

            Random rnd = new Random();
            for (int i = 0; i < numList.Length; i++)
            {
                numList[i] = rnd.Next(0, 1000);
            }

            return numList;
        }
    }
}
