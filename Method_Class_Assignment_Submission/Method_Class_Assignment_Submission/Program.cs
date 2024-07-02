using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class
            Calculation math = new Calculation();
            //Call the method in the class, passing in two numbers
            math.DoSomethings(30, Param2: 50);
            //Call the method in the class, specifying the parameters by name
            math.DoSomethings(Param1: 33, Param2: 55);
            Console.ReadLine();
        }
    }
}
