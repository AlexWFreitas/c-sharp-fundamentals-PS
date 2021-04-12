using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a Book object called book.
            // Adds a grades list to the book grades list.
            // Then use book method to show statistics about Average Grade / Highest Grade / Lowest Grade.
            Book book = new Book("Alex's Grade Book");

            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                
                if(input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }

            book.ShowStatistics();


            // book.AddGrades(new List<double>() { 25.2, 40.4, 133.5, 3.6, 34.2, 21.5, 100.01, 0.21, 23.43 });

            // book.ShowStatistics();
        }
    }
}