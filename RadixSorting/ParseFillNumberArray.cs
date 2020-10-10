using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace RadixSorting
{
    class ParseFillNumberArray
    {
        /// <summary>
        /// Creates a list of values by reading in an existing textfile and parsing them to have 3 digits. Returns these values as a List of strings.
        /// </summary>
        /// <param name="fileName">File to read.</param>
        /// <returns></returns>
        static public List<string> Fill(string fileName)
        {
            List<string> numList = new List<string>();
            foreach (string line in File.ReadLines(fileName))
            {
                string currNum = line;
                if (currNum.Length < 3)
                {
                    Console.WriteLine($"{currNum} isn't 3 digits long");
                    for (int i = 0; i < 3 - line.Length; i++)
                    {
                        currNum = "0" + currNum;
                    }
                }

                numList.Add(currNum);
            }

            return numList;
        }
    }
}
