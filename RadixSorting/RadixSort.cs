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
                }

                //Remove from buckets
                foreach (var bucket in buckets)
                {
                    while (bucket.Value.Count > 0)
                    {
                        sortingBucket.Add(bucket.Value[0]);
                        bucket.Value.RemoveAt(0);
                    }
                }
            }
            return initialList;
        }
    }
}
