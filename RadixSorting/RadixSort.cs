﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RadixSorting
{
    class RadixSort
    {
        /// <summary>
        /// Using the Bucket variant of Radix Sort, take, sort and return a list of integer arrays representing 3 digit numbers, printing out the number of steps it took to sort in the process.
        /// </summary>
        /// <param name="inputList">A list of 3 digit integers presented as an array [#][#][#] to be sorted.</param>
        /// <returns></returns>
        static public List<int[]> BucketVariant(List<int[]> inputList)
        {
            //  Counter for checking steps
            int count = 0;

            //  Create the swappable list and buckets for value swapping (swappable list is not strictly necessary, but I've kept it simply for clarity's sake)
            List<int[]> swapList = new List<int[]>(inputList);
            Dictionary<int, List<int[]>> buckets = new Dictionary<int, List<int[]>>();
            for (int i = 0; i <= 9; i++)
            {
                buckets.Add(i, new List<int[]>());
            }

            //  For each element, sort into buckets based on each digit starting with the last
            for (int i = 1; i <= 3; i++)    
            {
                //  Sort from swapList into buckets
                while (swapList.Count > 0)
                {
                    int[] currentIntArray = swapList[0];
                    swapList.RemoveAt(0);
                    buckets[currentIntArray[3 - i]].Add(currentIntArray);
                    count++;
                }

                //  Move from buckets to swapList
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

            Console.WriteLine($"Radix Bucket Sort took {count} steps to solve, using 10 buckets (0 to 9) to swap values.");
            return swapList;
        }

        /// <summary>
        /// Using the Counting variant of Radix Sort, take, sort and return a list of integer arrays representing 3 digit numbers, printing out the number of steps it took to sort in the process.
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns></returns>
        static public List<int[]> CountingVariant(List<int[]> inputList)
        {
            //  Create 2 arrays
                //  1 called output which we will use to copy values from and set as the new inputList, same size as inputList
                //  1 called counts, storing the count of each digit
            //  Starting from the first number in the inputList
                //  Check the last element
                    //Increment the counts array element corresponding to the last element
            //  Compute the Prefix Sum:
                //  From the first element on the count array, sum each element with the last value and set it as the current element
                //  eg. 1, 0, 1, 2, 0, 1 becomes 1, 1, 2, 4, 4, 5
            //  Starting from the last number in the inputList
                //  Check the last element
                    //  Check the corresponding count in that element's count in counterArray
                    //  Subtract 1 from the count, that is the position that that number has to go
                    //  eg. if number is 523, check the counted values in '3', then minus 1 from that count to get new index position
           
            
            //  Counter for checking steps
            int count = 0;

            //  Create outputList and counterArray
            List<int[]> outputList = new List<int[]>(inputList);
            int[] counterArray = {0,0,0,0,0,0,0,0,0,0};

            //  For each element
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"DEBUG - Checking digit {3 - i}");
                //  Add 1 to corresponding counter element of the same digit
                foreach (var input in inputList)
                {
                    counterArray[input[3 - i]]++;
                    Console.WriteLine($"Incremented value {input[3 - i]} to {counterArray[input[3 - i]]}");
                }

                //  Prefix Sum
                for (int j = 0; j < counterArray.Count(); j++)
                {
                    if (j > 0)
                    {
                        counterArray[j] = counterArray[j - 1] + counterArray[j];
                        Console.WriteLine($"New counter ({j}) is {counterArray[j]}");
                    }
                }

                //  Sort to outputList using prefix summed counterArray
                for (int j = inputList.Count - 1; j >= 0; j--)
                {

                    Console.WriteLine($"DEBUG - Checking inputList position {j} ({inputList[j][0]}{inputList[j][1]}{inputList[j][2]}) for its {3 - i} value, which is {inputList[j][3 - i]}");
                    Console.WriteLine($"counter value at {inputList[j][3 - i]} is {counterArray[inputList[j][3 - i]]}");
                    outputList[1 - (counterArray[inputList[j][3 - 1]])] = inputList[j];
                    //Console.WriteLine($"Added {outputList[inputList[j][3 - 1]][0]}{outputList[inputList[j][3 - 1]][1]}{outputList[inputList[j][3 - 1]][2]}");
                }

                //  Clear counterArray
                //  Overwrite the inputList
            }

            


            Console.WriteLine($"Radix Counting Sort took {count} steps to solve, using 10 buckets (0 to 9) to swap values.");
            return inputList;
        }

    }
}
