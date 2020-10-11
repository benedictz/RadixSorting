using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RadixSorting
{
    class RadixSort
    {
        static public List<char[]> BucketVariant(List<char[]> initialList)
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

            //  Create the buckets for value swapping
            Dictionary<int, List<string>> buckets = new Dictionary<int, List<string>>();
            for (int i = 0; i <= 9; i++)
            {
                buckets.Add(i, new List<string>());
            }

            //  For each element, sort into buckets based on each digit starting with the last
            int counter = 0;
            foreach (char[] charNum in initialList)
            {
            }

            //  Amount of numbers in each bucket.   --DEBUG--
            /*foreach (var bucket in buckets)
            {
                Console.WriteLine($"Bucket {bucket.Key} has {bucket.Value} numbers");
            }*/

            return initialList;    //  Change to sorted list when complete
        }
    }
}
