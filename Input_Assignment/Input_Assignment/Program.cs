using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number
            Console.WriteLine("Enter a number");
            int userGuess = Convert.ToInt32(Console.Read());
            using (StreamWriter file = new StreamWriter(@"C:\Users\HP\Desktop\aolcc\Basic_C#_Programs\Input_Assignment\log", true))
            {
                file.WriteLine(userGuess);
            }
        }
    }
}
