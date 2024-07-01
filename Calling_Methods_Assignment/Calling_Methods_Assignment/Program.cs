using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            PerformMath math = new PerformMath();

            math.Addition(userInput);
            math.Subtraction(userInput);
            math.Division(userInput);
            math.Multiplication(userInput);

            Console.ReadLine();
        }
    }
}
