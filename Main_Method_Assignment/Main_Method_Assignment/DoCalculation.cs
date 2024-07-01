using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class DoCalculation
    {
        //create a method that will take in an integer, create a math operation for this integer
        public int PerformAddition(int num1)
        {
            int result = num1 + 20;
            Console.WriteLine(result);
            return result;
        }

        public double PerformAddition(double num1)
        {
            double result = num1 + 8.5;
            Console.WriteLine(result);
            return result;
        }

        public string PerformAddition(string name)
        {
            string result = "My name is " + name;
            Console.WriteLine(result);
            return result;
        }
    }
}
