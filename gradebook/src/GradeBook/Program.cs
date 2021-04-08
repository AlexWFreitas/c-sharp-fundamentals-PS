using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Alex's Grade Book");

            book.AddGrades(new List<double>() { 25.2, 40.4, 133.5, 3.6, 34.2, 21.5, 100.01, 0.21, 23.43 });

            book.ShowStatistics();
        }
    }
}