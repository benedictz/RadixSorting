using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RadixSorting
{
    class RadixSort
    {
        /// <summary>
        /// Takes, sorts and returns a list of integer arrays representing 3 digit numbers, using the bucket variant of Radix Sort, printing out the number of steps it took to sort in the process.
        /// </summary>
        /// <param name="inputList">A list of 3 digit integers presented as an array [#][#][#] to be sorted.</param>
        /// <returns></returns>
        static public List<int[]> BucketVariant(List<int[]> inputList)
        {
            //  Counter for checking steps
            int count = 0;

            //  Create the swappable list and buckets for value swapping
            List<int[]> swapList = new List<int[]>(inputList);
            Dictionary<int, List<int[]>> buckets = new Dictionary<int, List<int[]>>();
            for (int i = 0; i <= 9; i++)
            {
                buckets.Add(i, new List<int[]>());
            }

            //  For each element, sort into buckets based on each digit starting with the last
            for (int i = 1; i <= 3; i++)    
            {
                //  Sort into buckets
                while (swapList.Count > 0)
                {
                    int[] currentIntArray = swapList[0];
                    swapList.RemoveAt(0);
                    buckets[currentIntArray[3 - i]].Add(currentIntArray);
                    count++;
                }

                //Remove from buckets
                foreach (var bucket in buckets)
                {
                    while (bucket.Value.Count > 0)
                    {
                        swapList.Add(bucket.Value[0]);
                        bucket.Value.RemoveAt(0);
                        count++;
                    }
                }
            }

            Console.WriteLine($"Radix Bucket Sort took {count} steps to solve.");
            return swapList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialList"></param>
        /// <returns></returns>
        static public List<int[]> CountingVariant(List<int[]> initialList)
        {
            //  Create 2 arrays
                //  1 called output, same size as input
                //  1 called counts, storing the count
            //  Starting from the first element of numbers
                //  Check the last element
                    //Increment the counts array element corresponding to the last element
            //  Compute the Prefix Sum:
                //  From the first element on the count array, sum each element with the last value and set it as the current element
                //  eg. 1, 0, 1, 2, 0, 1 becomes 1, 1, 2, 4, 4, 5
            //  

            return initialList;
        }

    }
}
