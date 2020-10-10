using System;
using System.Collections.Generic;
using System.Text;

namespace RadixSorting
{
    class RadixSort
    {
        static public List<string> BucketVariant(List<string> initialArray)
        {
            /*
            Create 10 containers labelled 0-9
            From the first element
                Read each value's last number
                Place that element into the corresponding container based on this last number
            From each bucket starting with 0
                Take the elements back out, starting with the first element that was placed

            Repeat: From the first element
                Read each value's second last number
                Place that element into the corresponding container based on this last number
            From each bucket starting with 0
                Take the elements back out, starting with the first element that was placed

            Repeat: From the first element
                Read each value's third last number
                Place that element into the corresponding container based on this last number
            From each bucket starting with 0
                Take the elements back out, starting with the first element that was placed

            List is now in order, return the number of steps taken to reach this list and the list itself to Main.
            */

            Dictionary<int, int> buckets = new Dictionary<int, int>();
            for (int i = 0; i <= 9; i++)
            {
                buckets.Add(i, 0);
            }

            //  Amount of numbers in each bucket.   --DEBUG--
            foreach (var bucket in buckets)
            {
                Console.WriteLine($"Bucket {bucket.Key} has {bucket.Value} numbers");
            }

            return initialArray;    //  Change to sorted list when complete
        }
    }
}
