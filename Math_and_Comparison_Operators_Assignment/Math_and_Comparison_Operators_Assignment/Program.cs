using System;

namespace Math_and_Comparison_Operators_Assignment
{
    class Program
    {
        static void Main()
        {
            //The program must start by printing “Anonymous Income Comparison Program” to the screen
            Console.WriteLine("Anonymous Income Comparison Program");
            //It must then print “Person 1” to the screen and get the following details - hourly rate & hours worked per week
            Console.WriteLine("Person 1");

            Console.WriteLine("Enter Hourly Rate");
            string enteredHourlyRate1 = Console.ReadLine();
            decimal hourlyRate1 = Convert.ToDecimal(enteredHourlyRate1);

            Console.WriteLine("Enter Hours Worked Per Week");
            string enteredHoursPerWeek1 = Console.ReadLine();
            int hoursPerWeek1 = Convert.ToInt32(enteredHoursPerWeek1);

         
            //It must then print “Person 2” to the screen and get the following details - hourly rate & hours worked per week
            Console.WriteLine("Person 2");

            Console.WriteLine("Enter Hourly Rate");
            string enteredHourlyRate2 = Console.ReadLine();
            decimal hourlyRate2 = Convert.ToDecimal(enteredHourlyRate2);

            Console.WriteLine("Enter Hours Worked Per Week");
            string enteredHoursPerWeek2 = Console.ReadLine();
            int hoursPerWeek2 = Convert.ToInt32(enteredHoursPerWeek2);


            //It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
            decimal annualSalary1 = (hourlyRate1 * hoursPerWeek1) * 54;
            Console.WriteLine("Annual salary of Person 1: \n" + annualSalary1);

            //It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.
            decimal annualSalary2 = (hourlyRate2 * hoursPerWeek2) * 54;
            Console.WriteLine("Annual salary of Person 1: \n" + annualSalary2);

            //It must then print to the screen “Person 1 makes more money than Person 2” and write the true or false value of this statement below it.
            bool comparedSalary = annualSalary1 > annualSalary2;
            Console.WriteLine("The result of the query if Person 1 makes more money than Person 2 is: \n" + comparedSalary.ToString());
            Console.ReadLine();
        }
    }
}
