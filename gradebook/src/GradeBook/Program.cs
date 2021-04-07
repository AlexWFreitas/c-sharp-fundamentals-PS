using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Alex's Grade Book");

            List<double> grades = new List<double>() { 25.2, 40.4, 133.5, 3.6 };

            foreach( var number in grades )
            {
                book.AddGrade(number);
            }
            Console.WriteLine(book.Name);
            book.Name = "One Piece 3333";
            Console.WriteLine(book.Name);
        }
    }
}