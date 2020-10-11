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
            Dictionary<int, List<char[]>> buckets = new Dictionary<int, List<char[]>>();
            for (int i = 0; i <= 9; i++)
            {
                buckets.Add(i, new List<char[]>());
            }

            //  For each element, sort into buckets based on each digit starting with the last
            for (int i = 1; i <= 3; i++)    //Length(3) - i(1) is 2, which is where the current array's max is. Will find a way to make this dynamic later.
            {
                Console.WriteLine($"Checking value at position {3 - i}");
                foreach (char[] charNum in initialList)
                {
                    Console.WriteLine($"The value to be checked in {string.Join("", charNum)} is {charNum[charNum.Length - i]}");
                }
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
