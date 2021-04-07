using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 25.2, 40.4, 133.5, 3.6 };
            double result = 0;

            foreach( var grade in grades )
            {
                result += grade;
            }

            result /= grades.Count;

            Console.WriteLine($"The average grade is {result:N1}.");
        }
    }
}