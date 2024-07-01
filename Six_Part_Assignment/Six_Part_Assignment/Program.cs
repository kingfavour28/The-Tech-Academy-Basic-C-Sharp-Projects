using System;
using System.Collections.Generic;

namespace Six_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Assignment Part 1
                string[] arrayOfStrings1 = { "Mega Chicken", "The Place Restaurant", "Chicken Republic" };
                Console.WriteLine("Please Enter a Text");
                string userInput = Console.ReadLine();
                for (int i = 0; i < arrayOfStrings1.Length; i++)
                {
                    arrayOfStrings1[i] = arrayOfStrings1[i] + userInput;
                }

                //Assignment Part 3: <=
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine(arrayOfStrings1[i]);
                }

                //Assignment Part 4/5
                List<string> colors = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "Red" };
                Console.WriteLine("Enter a rainbow color");
                string choiceColor = Console.ReadLine();

                foreach (string color in colors)
                {
                    if (color == choiceColor)
                    {
                        Console.WriteLine("Your choice of " + choiceColor + " exists at " + colors.IndexOf(color));
                    }
                    else
                    {
                        Console.WriteLine("Your choice of " + choiceColor + " does not exist in our array.");
                    }
                }
            } catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }


            Console.ReadLine();
        }
    }
}
