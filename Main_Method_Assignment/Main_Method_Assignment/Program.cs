using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DoCalculation math = new DoCalculation();

            //call the first method, passing in an integer
            math.PerformAddition(5);
            //call the second method, passing in a decimal
            math.PerformAddition(0.3);
            //call the third method, passing in a string
            math.PerformAddition("Favour Umogbai");
            Console.ReadLine();
        }
    }
}
