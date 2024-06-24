using System;

namespace Branching_Assignment_Submission
{
    class Program
    {
        static void Main()
        {
            //Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //prompted for the package weight
            Console.WriteLine("Enter Package Weight");
            string packageWeight = Console.ReadLine();
            int weight = Convert.ToInt32(packageWeight);
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //prompted for the package width
                Console.WriteLine("Enter Package Width");
                string packageWidth = Console.ReadLine();
                int width = Convert.ToInt32(packageWidth);

                //prompted for the package height
                Console.WriteLine("Enter Package Height");
                string packageHeight = Console.ReadLine();
                int height = Convert.ToInt32(packageHeight);

                //prompted for the package length
                Console.WriteLine("Enter Package Length");
                string packageLength = Console.ReadLine();
                int length = Convert.ToInt32(packageLength);

                //If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
                int total = width + height + length;
                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    //Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
                    int quote = ((width * height * length) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + '\n' + "Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
