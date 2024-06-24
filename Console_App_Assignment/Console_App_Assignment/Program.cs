using System;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //boolean comparison using a while statement.

            //Console.WriteLine("Enter a number");
            //string userNumber = Console.ReadLine();
            //int guess = Convert.ToInt32(userNumber);
            //while (guess != 10)
            //{
            //    Console.WriteLine("Wrong Guess");
            //    Console.WriteLine("Enter a number");
            //    userNumber = Console.ReadLine();
            //    guess = Convert.ToInt32(userNumber);
            //}
            //Console.WriteLine("You guessed right");
            //Console.ReadLine();

            //boolean comparison using a do while statement
            int guess;
            do
            {
                Console.WriteLine("Enter a number");
                string userNumber = Console.ReadLine();
                guess = Convert.ToInt32(userNumber);
                if (guess != 10)
                {
                    Console.WriteLine("Wrong Guess");
                }
                else
                {
                    Console.WriteLine("You guessed right");
                }
            } while (guess != 10);
            Console.ReadLine();
        }
    }
}
