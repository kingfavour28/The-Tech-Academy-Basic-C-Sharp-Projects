using System;
using System.Collections.Generic;

namespace Class_Method_Assignment
{
    //Create a class. 
    class Math
    {
        //In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
        public void Divide(int dividend)
        {
            int quotient = dividend / 2;
            Console.WriteLine(dividend + "divided by 2 is equal to " + quotient);
        }

        //Overload a method
        public void Divide(double dividend)
        {
            double quotient = dividend / 2;
            Console.WriteLine(dividend + "divided by 2 is equal to " + quotient);
        }
    }
}
