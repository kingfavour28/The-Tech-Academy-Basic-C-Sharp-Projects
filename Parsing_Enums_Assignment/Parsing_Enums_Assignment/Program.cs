using System;
using System.Collections.Generic;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        public enum daysOfTheWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day of the week");

            try
            {
                string uinput = Console.ReadLine();
                daysOfTheWeek userInput = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), uinput, true);
                Console.WriteLine("You enter " + userInput);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            Console.ReadLine();
        }
    }
}
