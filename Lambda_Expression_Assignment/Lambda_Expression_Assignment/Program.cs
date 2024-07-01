using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            string[] staffFirstName = { "Staff1", "Joe", "Staff3", "Staff4", "Staff5", "Staff6", "Joe", "Staff8", "Staff9", "Staff10" };
            string[] staffLastName = { "Staff1", "Joe", "Staff3", "Staff4", "Staff5", "Staff6", "Joe", "Staff8", "Staff9", "Staff10" };
            List<string> employeeDB = new List<string>();

            for (int i = 0; i< 10; i++)
            {
                employee.firstName = staffFirstName[i];
                employee.lastName = staffLastName[i];
                employeeDB.Add(employee.firstName + " " + employee.lastName);
            }

            foreach (string employeeName in employeeDB)
            {
                //if(employeeName == "Joe Joe") {
                //    Console.WriteLine(employeeName);
                //}
            }

            List<string> test = employeeDB.Where(x => x == "Joe Joe").ToList();
            foreach (string j in test)
            {
                Console.WriteLine(j);
            }
            //Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
