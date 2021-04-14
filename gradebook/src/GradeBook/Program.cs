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
            InMemoryBook book = new InMemoryBook("Alex's Grade Book");

            // Linking the GradeAdded Event to the OnGradeAdded Method
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            book.ShowStatistics();
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Log: Grade as added.");
        }
    }
}