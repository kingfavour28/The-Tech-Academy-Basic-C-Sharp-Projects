using System;
using System.Collections.Generic;

namespace Operators_Assignment_Submission
{
    //Make the Employee class take a generic type parameter
    class Employee<T>
    {
        //Create an Employee class with Id, FirstName and LastName properties. 
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.
        public List<T> things { get; set; }

        // overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
        public static bool operator== (Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.id == employee2.id;
        }

        public static bool operator!= (Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.id != employee2.id;
        }
    }
}
