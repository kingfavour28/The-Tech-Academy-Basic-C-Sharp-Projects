using System;
using System.Collections.Generic;

namespace Operators_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> staff1 = new Employee<string>();
            staff1.firstName = "Sample";
            staff1.lastName = "Student";
            staff1.id = 1;

            Employee<string> staff2 = new Employee<string>();
            staff2.firstName = "Favour";
            staff2.lastName = "Umogbai";
            staff2.id = 1;

            //Instantiate an Employee object with type “string” as its generic parameter
            Employee<string> staff3 = new Employee<string>();
            staff3.things = new List<string>() { "Computer", "Vehicle", "Printer" };

            //Instantiate an Employee object with type “int” as its generic parameter
            Employee<int> staff4 = new Employee<int>();
            staff4.things = new List<int>() { 1, 2, 3 };

            //Create a loop that prints all of the Things to the Console
            foreach (string thing in staff3.things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in staff4.things)
            {
                Console.WriteLine(thing);
            }

            //compare the two Employee objects using the newly overloaded operators and display the results.
            bool AreEqual = staff1 == staff2;
            bool AreNotEqual = staff1 != staff2;

            Console.WriteLine("Check for Equality resulted in: " + AreEqual.ToString());
            Console.WriteLine("Check for Inequality resulted in: " + AreNotEqual.ToString());

            Console.ReadLine();
        }
    }
}
