using System;
using System.Collections.Generic;

namespace Operators_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee staff1 = new Employee();
            staff1.firstName = "Sample";
            staff1.lastName = "Student";
            staff1.id = 1;

            Employee staff2 = new Employee();
            staff2.firstName = "Favour";
            staff2.lastName = "Umogbai";
            staff2.id = 1;

            //compare the two Employee objects using the newly overloaded operators and display the results.
            bool AreEqual = staff1 == staff2;
            bool AreNotEqual = staff1 != staff2;

            Console.WriteLine("Check for Equality resulted in: " + AreEqual.ToString());
            Console.WriteLine("Check for Inequality resulted in: " + AreNotEqual.ToString());

            Console.ReadLine();
        }
    }
}
