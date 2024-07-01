using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console.
            DateTime currentDateTime = DateTime.Now;
            Console.Write(currentDateTime);

            //Asks the user for a number.
            Console.Write("\nEnter a number");
            int hours = Convert.ToInt32(Console.Read());
            Console.ReadLine();

            DateTime futureTime = currentDateTime.AddHours(hours);
            Console.WriteLine(futureTime);
            Console.ReadLine();
        }
    }
}
