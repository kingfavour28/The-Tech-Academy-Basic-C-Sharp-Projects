using System;
using System.Collections.Generic;

namespace Calling_Methods_Assignment
{
    //Create a class. In that class, create three methods
    class PerformMath
    {
        public int Addition(int var1)
        {
            int result = var1 + 20;
            Console.WriteLine("The result for addition is - " + result);
            return result;
        }

        public int Subtraction(int var2)
        {
            int result = var2 - 20;
            Console.WriteLine("The result for subtraction is - " + result);
            return result;
        }

        public int Division(int var3)
        {
            int result = var3 / 20;
            Console.WriteLine("The result for division is - " + result);
            return result;
        }

        public int Multiplication(int var4)
        {
            int result = var4 * 20;
            Console.WriteLine("The result for multiplication is - " + result);
            return result;
        }
    }
}
