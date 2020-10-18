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
        /// <param name="initialList">A list of 3 digit integers presented as an array [#][#][#] to be sorted.</param>
        /// <returns></returns>
        static public List<int[]> BucketVariant(List<int[]> initialList)
        {
            //  Counter for checking steps
            int count = 0;

            //  Create the swappable list and buckets for value swapping
            List<int[]> sortingBucket = initialList;
            Dictionary<int, List<int[]>> buckets = new Dictionary<int, List<int[]>>();
            for (int i = 0; i <= 9; i++)
            {
                buckets.Add(i, new List<int[]>());
            }

            //  For each element, sort into buckets based on each digit starting with the last
            for (int i = 1; i <= 3; i++)    
            {
                //  Sort into buckets
                while (sortingBucket.Count > 0)
                {
                    int[] currentIntArray = sortingBucket[0];
                    sortingBucket.RemoveAt(0);
                    buckets[currentIntArray[3 - i]].Add(currentIntArray);
                    count++;
                }

                //Remove from buckets
                foreach (var bucket in buckets)
                {
                    while (bucket.Value.Count > 0)
                    {
                        sortingBucket.Add(bucket.Value[0]);
                        bucket.Value.RemoveAt(0);
                        count++;
                    }
                }
            }

            Console.WriteLine($"Steps taken: {count}");
            return initialList;
        }

        static public List<int[]> CountingVariant(List<int[]> initialList)
        {
            return initialList;
        }

    }
}
