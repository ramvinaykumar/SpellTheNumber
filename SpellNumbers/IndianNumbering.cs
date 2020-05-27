//-------------------------------------------------------------------------------------------------
//
// IndianNumbering.cs -- The IndianNumbering class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace SpellNumbers
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Class for writing the methods to perform the activity from derived class
    /// </summary>
    public static class IndianNumbering
    {
        #region Methods

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Spell The Number
        /// </summary>
        /// <param name="number">Int64 number</param>
        /// <returns>Spell The Number into string</returns>
        public static string SpellTheNumber(Int64 number)
        {
            string resultInWord = "";
            Int64 outputValue;
            if ((number / 10000000) > 0)
            {
                outputValue = number / 10000000;
                number = number % 10000000;
                resultInWord = resultInWord + ' ' + DigitToWords(outputValue) + " Crore";
            }
            if ((number / 100000) > 0)
            {
                outputValue = number / 100000;
                number = number % 100000;
                resultInWord = resultInWord + ' ' + DigitToWords(outputValue) + " Lakh";
            }
            if ((number / 1000) > 0)
            {
                outputValue = number / 1000;
                number = number % 1000;
                resultInWord = resultInWord + ' ' + DigitToWords(outputValue) + " Thousand";
            }
            if ((number / 100) > 0)
            {
                outputValue = number / 100;
                number = number % 100;
                resultInWord = resultInWord + ' ' + DigitToWords(outputValue) + " Hundred";
            }
            if ((number % 10) >= 0)
            {
                outputValue = number % 100;
                resultInWord = resultInWord + " " + DigitToWords(outputValue);
            }
            resultInWord = resultInWord + ' ' + "Only.";
            return resultInWord;
        }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Convert Digit To Words like 1 - One
        /// </summary>
        /// <param name="userInput">Int64 userInput</param>
        /// <returns>Return string value after converting Digit To Words</returns>
        public static string DigitToWords(Int64 userInput)
        {
            string wordResult = "";
            if ((userInput >= 1) && (userInput <= 10))
            {
                if ((userInput % 10) == 1) wordResult = "One";
                if ((userInput % 10) == 2) wordResult = "Two";
                if ((userInput % 10) == 3) wordResult = "Three";
                if ((userInput % 10) == 4) wordResult = "Four";
                if ((userInput % 10) == 5) wordResult = "Five";
                if ((userInput % 10) == 6) wordResult = "Six";
                if ((userInput % 10) == 7) wordResult = "Seven";
                if ((userInput % 10) == 8) wordResult = "Eight";
                if ((userInput % 10) == 9) wordResult = "Nine";
                if ((userInput % 10) == 0) wordResult = "Ten";
            }
            if (userInput > 9 && userInput < 20)
            {
                if (userInput == 11) wordResult = "Eleven";
                if (userInput == 12) wordResult = "Twelve";
                if (userInput == 13) wordResult = "Thirteen";
                if (userInput == 14) wordResult = "Forteen";
                if (userInput == 15) wordResult = "Fifteen";
                if (userInput == 16) wordResult = "Sixteen";
                if (userInput == 17) wordResult = "Seventeen";
                if (userInput == 18) wordResult = "Eighteen";
                if (userInput == 19) wordResult = "Nineteen";
            }
            if (userInput > 20 && (userInput / 10) == 2 && (userInput % 10) == 0) wordResult = "Twenty";
            if (userInput > 20 && (userInput / 10) == 3 && (userInput % 10) == 0) wordResult = "Thirty";
            if (userInput > 20 && (userInput / 10) == 4 && (userInput % 10) == 0) wordResult = "Forty";
            if (userInput > 20 && (userInput / 10) == 5 && (userInput % 10) == 0) wordResult = "Fifty";
            if (userInput > 20 && (userInput / 10) == 6 && (userInput % 10) == 0) wordResult = "Sixty";
            if (userInput > 20 && (userInput / 10) == 7 && (userInput % 10) == 0) wordResult = "Seventy";
            if (userInput > 20 && (userInput / 10) == 8 && (userInput % 10) == 0) wordResult = "Eighty";
            if (userInput > 20 && (userInput / 10) == 9 && (userInput % 10) == 0) wordResult = "Ninty";

            if (userInput > 20 && (userInput / 10) == 2 && (userInput % 10) != 0)
            {
                if ((userInput % 10) == 1) wordResult = "Twenty One";
                if ((userInput % 10) == 2) wordResult = "Twenty Two";
                if ((userInput % 10) == 3) wordResult = "Twenty Three";
                if ((userInput % 10) == 4) wordResult = "Twenty Four";
                if ((userInput % 10) == 5) wordResult = "Twenty Five";
                if ((userInput % 10) == 6) wordResult = "Twenty Six";
                if ((userInput % 10) == 7) wordResult = "Twenty Seven";
                if ((userInput % 10) == 8) wordResult = "Twenty Eight";
                if ((userInput % 10) == 9) wordResult = "Twenty Nine";
            }
            if (userInput > 20 && (userInput / 10) == 3 && (userInput % 10) != 0)
            {
                if ((userInput % 10) == 1) wordResult = "Thirty One";
                if ((userInput % 10) == 2) wordResult = "Thirty Two";
                if ((userInput % 10) == 3) wordResult = "Thirty Three";
                if ((userInput % 10) == 4) wordResult = "Thirty Four";
                if ((userInput % 10) == 5) wordResult = "Thirty Five";
                if ((userInput % 10) == 6) wordResult = "Thirty Six";
                if ((userInput % 10) == 7) wordResult = "Thirty Seven";
                if ((userInput % 10) == 8) wordResult = "Thirty Eight";
                if ((userInput % 10) == 9) wordResult = "Thirty Nine";
            }
            if (userInput > 20 && (userInput / 10) == 4 && (userInput % 10) != 0)
            {
                if ((userInput % 10) == 1) wordResult = "Forty One";
                if ((userInput % 10) == 2) wordResult = "Forty Two";
                if ((userInput % 10) == 3) wordResult = "Forty Three";
                if ((userInput % 10) == 4) wordResult = "Forty Four";
                if ((userInput % 10) == 5) wordResult = "Forty Five";
                if ((userInput % 10) == 6) wordResult = "Forty Six";
                if ((userInput % 10) == 7) wordResult = "Forty Seven";
                if ((userInput % 10) == 8) wordResult = "Forty Eight";
                if ((userInput % 10) == 9) wordResult = "Forty Nine";
            }
            if (userInput > 20 && (userInput / 10) == 5 && (userInput % 10) != 0)
            {
                if ((userInput % 10) == 1) wordResult = "Fifty One";
                if ((userInput % 10) == 2) wordResult = "Fifty Two";
                if ((userInput % 10) == 3) wordResult = "Fifty Three";
                if ((userInput % 10) == 4) wordResult = "Fifty Four";
                if ((userInput % 10) == 5) wordResult = "Fifty Five";
                if ((userInput % 10) == 6) wordResult = "Fifty Six";
                if ((userInput % 10) == 7) wordResult = "Fifty Seven";
                if ((userInput % 10) == 8) wordResult = "Fifty Eight";
                if ((userInput % 10) == 9) wordResult = "Fifty Nine";
            }
            if (userInput > 20 && (userInput / 10) == 6 && (userInput % 10) != 0)
            {
                if ((userInput % 10) == 1) wordResult = "Sixty One";
                if ((userInput % 10) == 2) wordResult = "Sixty Two";
                if ((userInput % 10) == 3) wordResult = "Sixty Three";
                if ((userInput % 10) == 4) wordResult = "Sixty Four";
                if ((userInput % 10) == 5) wordResult = "Sixty Five";
                if ((userInput % 10) == 6) wordResult = "Sixty Six";
                if ((userInput % 10) == 7) wordResult = "Sixty Seven";
                if ((userInput % 10) == 8) wordResult = "Sixty Eight";
                if ((userInput % 10) == 9) wordResult = "Sixty Nine";
            }
            if (userInput > 20 && (userInput / 10) == 7 && (userInput % 10) != 0)
            {
                if ((userInput % 10) == 1) wordResult = "Seventy One";
                if ((userInput % 10) == 2) wordResult = "Seventy Two";
                if ((userInput % 10) == 3) wordResult = "Seventy Three";
                if ((userInput % 10) == 4) wordResult = "Seventy Four";
                if ((userInput % 10) == 5) wordResult = "Seventy Five";
                if ((userInput % 10) == 6) wordResult = "Seventy Six";
                if ((userInput % 10) == 7) wordResult = "Seventy Seven";
                if ((userInput % 10) == 8) wordResult = "Seventy Eight";
                if ((userInput % 10) == 9) wordResult = "Seventy Nine";
            }
            if (userInput > 20 && (userInput / 10) == 8 && (userInput % 10) != 0)
            {
                if ((userInput % 10) == 1) wordResult = "Eighty One";
                if ((userInput % 10) == 2) wordResult = "Eighty Two";
                if ((userInput % 10) == 3) wordResult = "Eighty Three";
                if ((userInput % 10) == 4) wordResult = "Eighty Four";
                if ((userInput % 10) == 5) wordResult = "Eighty Five";
                if ((userInput % 10) == 6) wordResult = "Eighty Six";
                if ((userInput % 10) == 7) wordResult = "Eighty Seven";
                if ((userInput % 10) == 8) wordResult = "Eighty Eight";
                if ((userInput % 10) == 9) wordResult = "Eighty Nine";
            }
            if (userInput > 20 && (userInput / 10) == 9 && (userInput % 10) != 0)
            {
                if ((userInput % 10) == 1) wordResult = "Ninty One";
                if ((userInput % 10) == 2) wordResult = "Ninty Two";
                if ((userInput % 10) == 3) wordResult = "Ninty Three";
                if ((userInput % 10) == 4) wordResult = "Ninty Four";
                if ((userInput % 10) == 5) wordResult = "Ninty Five";
                if ((userInput % 10) == 6) wordResult = "Ninty Six";
                if ((userInput % 10) == 7) wordResult = "Ninty Seven";
                if ((userInput % 10) == 8) wordResult = "Ninty Eight";
                if ((userInput % 10) == 9) wordResult = "Ninty Nine";
            }
            return wordResult;
        }

        #endregion
    }
}
