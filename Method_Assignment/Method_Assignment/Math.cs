using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Math
    {
        //create a method that takes two integers as parameters. Make one of them optional. 
        public static int PerformAddition(int num1, int num2 = 20)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }
    }
}
