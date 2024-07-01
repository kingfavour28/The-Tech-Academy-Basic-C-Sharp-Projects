using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate that class.
            Math mathematics = new Math();

            //user should enter input
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            mathematics.Divide(userInput);
            Console.ReadLine();
        }
    }
}
