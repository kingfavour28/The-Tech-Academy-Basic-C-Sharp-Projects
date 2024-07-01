using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Name: ");
            Employee employee = new Employee();
            employee.SayName("Sample", "Student");

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable Staff = new Employee();
            employee.Quit();

            Console.ReadLine();
        }


    }
}
