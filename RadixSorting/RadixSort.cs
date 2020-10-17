using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RadixSorting
{
    class RadixSort
    {
        static public List<int[]> BucketVariant(List<int[]> initialList)
        {
            //  Create the buckets for value swapping
            Dictionary<int, List<int[]>> buckets = new Dictionary<int, List<int[]>>();
            for (int i = 0; i <= 9; i++)
            {
                buckets.Add(i, new List<int[]>());
            }

            //  For each element, sort into buckets based on each digit starting with the last
            for (int i = 1; i <= 3; i++)    
            {
                Console.WriteLine($"Checking value at position {3 - i}");
                foreach (int[] intArray in initialList)
                {
                    Console.WriteLine($"Value at {3 - i} is {intArray[3 - i]}");
                }
            }

            //  Amount of numbers in each bucket.   --DEBUG--
            foreach (var bucket in buckets)
            {
                Console.WriteLine($"Bucket {bucket.Key} has {bucket.Value.Count} numbers");
            }

            return initialList;    //  Change to sorted list when complete
        }
    }
}
