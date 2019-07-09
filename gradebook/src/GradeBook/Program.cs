using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)     //static are not associated with object instance
        {
            var book = new Book("Sami's Grade Book");
            book.AddGrade(89.2);
            book.AddGrade(77.5);
            book.AddGrade(71.5);
            book.GetStatistics();


            var stats = book.GetStatistics();

            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The higher grade is {stats.High}");
            System.Console.WriteLine($"The lower grade is {stats.Low}");     
        }
    }
}
