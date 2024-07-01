using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    class Calculation
    {
        //Create a class. In that class, create a void method that takes two integers as parameters. 
        public static void DoSomethings(int Param1, int Param2)
        {
            //Have the method do a math operation on the first integer and display the second integer to the screen. 
            int result = Param1 + 45;
            Console.WriteLine("Your first parameter plus 45 is equal to " + result);
            Console.WriteLine("Your second parameter is: " + Param2);
        }
    }
}
