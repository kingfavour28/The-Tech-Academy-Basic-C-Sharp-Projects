using System;

namespace StudentDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Create and save a new student
                var student = new Student
                {
                    Name = "John Doe",
                    Age = 20
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully.");
            }
        }
    }
}
