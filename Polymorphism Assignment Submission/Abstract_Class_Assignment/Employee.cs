using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    //Have your Employee class from the previous drill inherit that interface
    class Employee : Person, IQuittable
    {
        public override void SayName(string fName, string lName)
        {
            Console.WriteLine("Hello " + fName + " " + lName);
        }

        //Implement the Quit() method in any way you choose.
        public void Quit()
        {
            Console.WriteLine("You can quit now!");
        }
    }
}
