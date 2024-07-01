using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Person
    {
        //properties of the class below:
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //method of the class below:
        public void SayName()
        {
            string name = "Name: " + "[" + FirstName + " " + LastName + "]";
            Console.WriteLine(name);
        }
    }
}
