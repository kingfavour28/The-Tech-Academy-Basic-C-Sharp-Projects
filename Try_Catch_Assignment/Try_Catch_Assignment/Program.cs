using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their age
            Console.WriteLine("Enter your age");
            int age;
            bool validAnswer = int.TryParse(Console.ReadLine(), out age);
            try
            {
                if (!validAnswer || age < 0) throw new Exception();
                DateTime currentDate = DateTime.Now;
                int YOB = currentDate.Year - age;
                //Display the year the user was born
                Console.WriteLine(YOB);
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Enter a correct age");
            }
            //Display a general message if an exception was caused by anything else.
            Console.WriteLine("If error persists contact system administrator");
            Console.ReadLine();
        }
    }
}
