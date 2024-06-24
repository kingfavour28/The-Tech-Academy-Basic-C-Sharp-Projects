using System;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
            Console.WriteLine("Enter a number");
            string enteredNumber1 = Console.ReadLine();
            ulong userInput1 = Convert.ToUInt64(enteredNumber1);
            ulong calc1 = userInput1 * 50;
            Console.Write("Your input multiplied by 50 is equal to: " + calc1);
            Console.ReadLine();

            //Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Enter a number");
            string enteredNumber2 = Console.ReadLine();
            double userInput2 = Convert.ToDouble(enteredNumber2);
            double calc2 = userInput2 + 25;
            Console.Write("Your input plus 25 is equal to: " + calc2);
            Console.ReadLine();

            //Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Enter a number");
            string enteredNumber3 = Console.ReadLine();
            double userInput3 = Convert.ToDouble(enteredNumber3);
            double calc3 = userInput3 / 12.5;
            Console.Write("Your input divided by 12.5 is equal to: " + calc3);
            Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            Console.WriteLine("Enter a number");
            string enteredNumber4 = Console.ReadLine();
            double userInput4 = Convert.ToDouble(enteredNumber4);
            bool calc4 = userInput4 > 50;
            Console.Write("Your checked against being greater than 50 is equal to: " + calc4.ToString());
            Console.ReadLine();

            //Takes an input from the user, divides it by 7, then prints the remainder to the console
            Console.WriteLine("Enter a number");
            string enteredNumber5 = Console.ReadLine();
            double userInput5 = Convert.ToDouble(enteredNumber5);
            double calc5 = userInput3 % 7;
            Console.Write("Your input divided by 7 will give a remainder that is equal to: " + calc5);
            Console.ReadLine();
        }
    }
}
