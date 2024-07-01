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
            Console.ReadLine();
        }
    }
}
