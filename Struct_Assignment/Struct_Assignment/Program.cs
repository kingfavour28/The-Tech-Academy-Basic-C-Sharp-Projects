using System;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create an object of data type Number and assign an amount to it.
            Number obj = new Number();
            obj.Amount = 50.67m;
            Console.WriteLine(obj.Amount);
            Console.ReadLine();
        }
    }

    //Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
    public struct Number
    {
        public decimal Amount { get; set; }
    }
}
