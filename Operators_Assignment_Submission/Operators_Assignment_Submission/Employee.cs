using System;
using System.Collections.Generic;

namespace Operators_Assignment_Submission
{
    class Employee
    {
        //Create an Employee class with Id, FirstName and LastName properties. 
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        // overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.id == employee2.id;
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.id != employee2.id;
        }
    }
}
