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

            string choice;

            do
            {
                Console.WriteLine("Enter an option: ");
                Console.WriteLine("1. Enter a grade.");
                Console.WriteLine("2. Show statistics.");
                Console.WriteLine("3. Show list of grades.");
                Console.WriteLine("Q. Quit.");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter a grade: ");
                        double grade = double.Parse(Console.ReadLine());
                        book.AddGrade(grade);
                        break;

                    case "2":
                        book.ShowStatistics();
                        break;

                    case "3":
                        Console.WriteLine("List of Grades: ");
                        foreach (double number in book.Grades)
                        {
                            Console.WriteLine(number);
                        }
                        break;

                    default:
                        break;
                }


            } while (!choice.Equals("Q"));
        }
    }
}