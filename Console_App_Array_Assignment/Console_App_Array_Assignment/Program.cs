using System;
using System.Collections.Generic;

namespace Console_App_Array_Assignment
{
    class Program
    {
        static void Main()
        {
            //one-dimensional Array of strings
            string[] arrayOfStrings = {"Imade", "Ibukun", "Imoh", "Iniobong"};

            //Ask the user to select an index of the Array.
            Console.WriteLine("Choose an index between 0 and 3");
            string userChoice1 = Console.ReadLine();
            int choice1 = Convert.ToInt32(userChoice1);

            //display the string at that index on the screen
            if (choice1 > 3)
            {
                //Add in a message that displays when the user selects an index that doesn’t exist.
                Console.WriteLine("Index does not exist");
            }
            else
            {
                string matchingString1 = arrayOfStrings[choice1];
                Console.WriteLine("The matching string is - " + matchingString1);
            }


            //one-dimensional Array of integers
            int[] arrayOfInt = { 1, 3, 5, 7 };

            //Ask the user to select an index of the Array.
            Console.WriteLine("Choose an index between 0 and 3");
            string userChoice2 = Console.ReadLine();
            int choice2 = Convert.ToInt32(userChoice2);

            //display the integer at that index on the screen
            if (choice2 > 3)
            {
                //Add in a message that displays when the user selects an index that doesn’t exist.
                Console.WriteLine("Index does not exist");
            }
            else
            {
                int matchingString2 = arrayOfInt[choice2];
                Console.WriteLine("The matching integer is - " + matchingString2);
            }

            //Create a list of strings.
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Francis");
            listOfStrings.Add("Olumide");
            listOfStrings.Add("Boluwatife");
            listOfStrings.Add("Ofofonono");

            //Ask the user to select an index of the list and then display the content at that index on the screen.
            Console.WriteLine("Choose an index between 0 and 3");
            string userChoice3 = Console.ReadLine();
            int choice3 = Convert.ToInt32(userChoice3);

            //display the integer at that index on the screen
            if (choice3 > 3)
            {
                //Add in a message that displays when the user selects an index that doesn’t exist.
                Console.WriteLine("Index does not exist");
            }
            else
            {
                string matchingString3 = listOfStrings[choice3];
                Console.WriteLine("The matching integer is - " + matchingString3);
            }

            Console.ReadLine();
        }
    }
}
