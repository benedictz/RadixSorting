using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace RadixSorting
{
    class ParseFillNumberArray
    {
        /// <summary>
        /// Creates a list of values by reading in an existing textfile and parsing them to have 3 digits. Returns these values as a List of char arrays.
        /// </summary>
        /// <param name="fileName">File to read.</param>
        /// <returns></returns>
        static public List<char[]> Fill(string fileName)
        {
            List<char[]> charList = new List<char[]>();
            foreach (string line in File.ReadLines(fileName))
            {
                string currentLine = line;
                if (currentLine.Length < 3)
                {
                    Console.WriteLine($"--DEBUG--   {currentLine} isn't 3 digits long");
                    for (int i = 0; i < 3 - line.Length; i++)
                    {
                        currentLine = "0" + currentLine;
                    }
                }

                char[] currentNum = currentLine.ToCharArray();
                charList.Add(currentNum);
            }

            return charList;
        }
    }
}
