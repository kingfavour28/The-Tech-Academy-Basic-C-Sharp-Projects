using System;
using System.Text;

namespace String_Assignment
{
    class Program
    {
        static void Main()
        {
            //Concatenates three strings.
            string firstString = "I am";
            string secondString = " Favour";
            string thirdString = " Umogbai";
            string result1 = firstString + secondString + thirdString;
            Console.WriteLine(result1);

            //Converts a string to uppercase.
            string nameToUpperCase = result1.ToUpper();
            Console.WriteLine(nameToUpperCase);

            //Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.
            StringBuilder result2 = new StringBuilder();
            result2.Append(firstString + "\n");
            result2.Append(secondString + "\n");
            result2.Append(thirdString);

            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
