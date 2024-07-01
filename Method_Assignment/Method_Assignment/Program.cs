using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("Enter your second, number will be set to 20 if you do not input one");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Math.PerformAddition(num1, num2);
            }
            catch
            {
                Math.PerformAddition(num1);
            }

            Console.ReadLine();
        }
    }
}
