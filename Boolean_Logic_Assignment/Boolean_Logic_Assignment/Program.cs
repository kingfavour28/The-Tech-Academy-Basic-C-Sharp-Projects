using System;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main()
        {
            //Here we ask questions
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI?, \"yes\" or \"no\" only");
            string DUIUpdate = Console.ReadLine();
            bool hadDUI = (DUIUpdate == "yes");

            Console.WriteLine("How many speeding tickets do you have?");
            string numberOfSpeedingTickets = Console.ReadLine();
            int speedingTicketsCount = Convert.ToInt32(numberOfSpeedingTickets);

            //determine if user qualifies for insurance
            bool qualified = userAge >= 15 && !hadDUI && speedingTicketsCount < 4;
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
