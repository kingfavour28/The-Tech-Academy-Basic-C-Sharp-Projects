using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Employee: Person
    {
        public override void SayName(string fName, string lName)
        {
            Console.WriteLine("Hello " + fName + " " + lName);
        }
    }
}
