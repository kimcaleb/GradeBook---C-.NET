using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Caleb's Gradebook");   
            book.AddGrade(12.2); 
            book.AddGrade(1.4);
            book.AddGrade(77.1);
            var stats = book.GetStatistics();          
            

            Console.WriteLine($"THe average grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            
        }
    }
}
