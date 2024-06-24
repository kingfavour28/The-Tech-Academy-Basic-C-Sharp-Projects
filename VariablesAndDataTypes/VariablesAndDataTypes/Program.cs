using System;


    class Program
    {
        static void Main()
        {
        //Console.WriteLine("What is your name?");
        //string yourName = Console.ReadLine();
        //Console.WriteLine("Your name is: " + yourName);
        //Console.ReadLine();

        Console.WriteLine("What is your favourite number?");
        string favouriteNumber = Console.ReadLine();
        int favNum = Convert.ToInt32(favouriteNumber);
        int total = favNum + 5;
        string text = "Your favourite number plus 5 is: ";
        Console.WriteLine(text + total);
        //Why does the above operation work when C# is a strongly typed language?
        Console.ReadLine();
        }
    }
