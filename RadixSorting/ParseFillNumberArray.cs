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
        /// Creates a list of values by reading in an existing textfile and parsing them to have 3 digits. Returns these values as a string array.
        /// </summary>
        /// <param name="fileName">File to read.</param>
        /// <returns></returns>
        static public string[] Fill(string fileName)
        {
            string[] numArray = new string[File.ReadLines(fileName).Count()];
            int i = 0;
            foreach (string line in File.ReadLines(fileName))
            {
                string currNum = line;
                if (currNum.Length < 3)
                {
                    Console.WriteLine($"{currNum} isn't 3 digits long");
                    for (int j = 0; j < 3 - line.Length; j++)
                    {
                        currNum = "0" + currNum;
                    }
                }

                numArray[i] = currNum;
                i++;
            }

            return numArray;
        }
    }
}
