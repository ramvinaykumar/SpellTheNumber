//-------------------------------------------------------------------------------------------------
//
// InternationNumbering.cs -- The InternationNumbering class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace SpellNumbers
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// International Number Format
    /// </summary>
    public static class InternationNumbering
    {
        #region Variable

        static string[] numberMap = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] digintNumberMap = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        #endregion

        #region Method

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Number To Words
        /// </summary>
        /// <param name="userInput">Int64 userInput</param>
        /// <returns>Return the userInput as word</returns>
        public static string NumberToWords(Int64 userInput)
        {
            if (userInput == 0)
                return "Zero";

            if (userInput < 0)
                return "Minus " + NumberToWords(Math.Abs(userInput));

            string spelledWords = "";

            if ((userInput / 1000000000) > 0)
            {
                spelledWords += NumberToWords(userInput / 1000000000) + " Billion ";
                userInput %= 1000000000;
            }

            if ((userInput / 1000000) > 0)
            {
                spelledWords += NumberToWords(userInput / 1000000) + " Million ";
                userInput %= 1000000;
            }

            if ((userInput / 1000) > 0)
            {
                spelledWords += NumberToWords(userInput / 1000) + " Thousand ";
                userInput %= 1000;
            }

            if ((userInput / 100) > 0)
            {
                spelledWords += NumberToWords(userInput / 100) + " Hundred ";
                userInput %= 100;
            }

            if (userInput > 0)
            {
                if (userInput < 20)
                {
                    spelledWords += numberMap[userInput];
                }
                else
                {
                    spelledWords += digintNumberMap[userInput / 10];
                    if ((userInput % 10) > 0)
                    {
                        spelledWords += " " + numberMap[userInput % 10];
                    }
                }
            }

            return spelledWords;
        }

        #endregion
    }
}
