//-------------------------------------------------------------------------------------------------
//
// Program.cs -- The Program class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace SpellNumbers
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Program Class: Entry point to Console application
    /// </summary>
    class Program
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Main method
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                // Type a numeric argument
                Console.WriteLine("Please enter number(s): ");

                // Create a variable and get user input from the keyboard and store it in the variable
                long inputValue = long.Parse(Console.ReadLine());

                Console.WriteLine("Indian number system...");
                Console.WriteLine($"The Output of user entered number is >>> {IndianNumbering.SpellTheNumber(inputValue)}");

                Console.WriteLine("International number system...");
                Console.WriteLine($"The Output of user entered number is >>> {InternationNumbering.NumberToWords(inputValue)}");

                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
