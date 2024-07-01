using System;
using System.Collections.Generic;

namespace Console_App_Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main()
        {
            //Create a list of integers.
            List<int> integerList = new List<int> { 24, 76, 33, 5 };
            //Ask the user for a number to divide each number in the list by
            Console.WriteLine("Enter your preffered divisor");
            try
            {
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int integer in integerList)
                {
                    int result = integer / divisor;
                    Console.WriteLine(integer + " divided by " + divisor + " is equal to " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block
                Console.WriteLine("Thank you for trying this out with us!");
            }
            Console.WriteLine("You have exited the try/catch block");
            Console.ReadLine();
        }
    }
}
