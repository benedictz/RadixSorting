namespace RadixSorting
{
    class ToIntArray
    {
        /// <summary>
        /// Takes a 3 digit integer (or less) and converts it into an integer array of the 3 digits.
        /// </summary>
        /// <param name="num">The number to convert.</param>
        /// <returns>Array of 3 integers representing the digits of the input integer</returns>
        static public int[] Convert(int num)
        {
            int currNum = num;
            int[] intArray = new int[3];

            //  Gets the remainder after dividing a number by 10, and sets these to corresponding intArray position.
            while (currNum != 0)
            {
                for (int i = intArray.Length - 1; i >= 0; i--)
                {
                    intArray[i] = currNum % 10;
                    currNum = currNum / 10;
                }
            }

            return intArray;
        }
    }
}
