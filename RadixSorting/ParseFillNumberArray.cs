using System.Collections.Generic;
using System.IO;

namespace RadixSorting
{
    class ParseFillNumberArray
    {
        /// <summary>
        /// Creates a list of values by reading in an existing textfile and parsing them to have 3 digits. Returns these values as a list of integer arrays.
        /// </summary>
        /// <param name="fileName">File to read.</param>
        /// <returns></returns>
        static public List<int[]> Fill(string fileName)
        {
            List<int[]> numList = new List<int[]>();
            foreach (string line in File.ReadLines(fileName))
            {
                string currentLine = line;
                int[] numArray = ToIntArray.Convert(int.Parse(currentLine));
                numList.Add(numArray);
            }

            return numList;
        }
    }
}
