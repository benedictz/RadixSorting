using System.Collections.Generic;
using System.Linq;

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
                }

                //  Move from buckets to swapList
                foreach (var bucket in buckets)
                {
                    while (bucket.Value.Count > 0)
                    {
                        swapList.Add(bucket.Value[0]);
                        bucket.Value.RemoveAt(0);
                    }
                }
            }

            return swapList;
        }

        /// <summary>
        /// Using the Counting variant of Radix Sort, take, sort and return a list of integer arrays representing 3 digit numbers, printing out the number of steps it took to sort in the process.
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns></returns>
        static public List<int[]> CountingVariant(List<int[]> inputList)
        {
            //  Create randList, swapList and counterArray
            List<int[]> randList = new List<int[]>(inputList);
            List<int[]> swapList = new List<int[]>();
            for (int x = 0; x < randList.Count(); x++)
            {
                swapList.Add(null);
            }

            int[] counterArray = {0,0,0,0,0,0,0,0,0,0};

            //  For each element
            for (int i = 1; i <= 3; i++)
            {
                //  Add 1 to corresponding counter element of the same digit
                foreach (var input in randList)
                {
                    counterArray[input[3 - i]]++;
                }

                //  Prefix Sum
                for (int j = 0; j < counterArray.Count(); j++)
                {
                    if (j > 0)
                    {
                        counterArray[j] = counterArray[j - 1] + counterArray[j];
                    }
                }

                //  Sort to outputList using prefix summed counterArray
                for (int k = randList.Count - 1; k >= 0; k--)
                {
                    counterArray[randList[k][3 - i]] = counterArray[randList[k][3 - i]] - 1;
                    swapList[(counterArray[randList[k][3 - i]])] = randList[k];
                }

                //  Clear counterArray
                for (int y = 0; y < counterArray.Count(); y++)
                {
                    counterArray[y] = 0;
                }

                //  Overwrite the inputList
                for (int l = 0; l < swapList.Count(); l++)
                {
                    randList[l] = swapList[l];
                }
            }

            return randList;
        }

    }
}
