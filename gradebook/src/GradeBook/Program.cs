using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new[] { 23.3, 24, 25.1, 89.1, 22.3 };
            List<double> grades = new List<double>() { 13.2, 13.4, 13.5, 13.6 };
            double sum = 0;

            grades.AddRange(numbers);

            foreach( var grade in grades )
            {
                sum += grade;
            }
            Console.WriteLine( sum / grades.Count );
        }
    }
}