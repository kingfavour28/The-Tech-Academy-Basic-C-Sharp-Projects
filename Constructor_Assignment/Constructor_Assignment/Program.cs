using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable
            const string businessName = "Iyanu and Sons";
            Console.WriteLine("Welcome to " + businessName + "Business Centre. Please enter your name:\n");
            //Create a variable using the keyword “var.”
            var username = Console.Read(); 
        }
    }

    //Chain two constructors together.
    public class Product
    {
        public Product(string name):this(name, 2)
        {

        }

        public Product(string name, int id)
        {

        }
    }
}
