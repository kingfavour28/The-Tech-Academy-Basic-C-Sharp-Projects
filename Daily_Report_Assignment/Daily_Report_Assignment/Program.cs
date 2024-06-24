using System;

    class Program
    {
        static void Main()
        {
        //Welcome user
        Console.WriteLine("Academy of Learning Career College \nStudent Daily Report. ");
        //Get user name
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine();
        //Get user course
        Console.WriteLine("What course are you on?");
        string studentCourse = Console.ReadLine();
        //Get page number
        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        //Convert page number to integer
        int pageNum = Convert.ToInt32(pageNumber);
        //Enquire if user needs help
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\";");
        string helpResponse = Console.ReadLine();
        //Convert help response to boolean
        bool needHelp = bool.Parse(helpResponse);
        //Enquire if user has any positive experiences to share
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();
        //Request for feedback
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
        string feedback = Console.ReadLine();
        //Get number of study hours
        Console.WriteLine("How many hours did you study today?");
        string dailyStudyHours = Console.ReadLine();
        //Convert study hours to integer
        int hours = Convert.ToInt32(dailyStudyHours);
        //Goodbye greeting
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        Console.ReadLine();
    }
}
