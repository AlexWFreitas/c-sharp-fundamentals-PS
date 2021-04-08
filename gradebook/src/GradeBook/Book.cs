using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Book
    {
        // Public Properties
        public string Name
        {
            set => name = value;
            get => name;
        }
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Error: Grade {grade} is above 100 or lower than 0.");
            }
        }

        // Public Methods
        public void AddGrades(List<double> grades)
        {
            foreach (double grade in grades)
            {
                AddGrade(grade);
            }
        }
        public void ShowStatistics()
        {
            Console.WriteLine($"The average grade on this grade book is {CalcAverageGrade()}");
            Console.WriteLine($"The highest grade on this grade book is {CalcMaxGrade()}");
            Console.WriteLine($"The lowest grade on this grade book is {CalcMinGrade()}");
        }


        // Private Properties
        private List<double> grades;
        private string name;


        // Private Methods
        private double CalcMaxGrade()
        {
            double maxValue = double.MinValue;
            foreach(double grade in grades)
            {
                maxValue = Math.Max(grade, maxValue);
            }
            return maxValue;
        }
        private double CalcMinGrade()
        {
            double minValue = double.MaxValue;
            foreach (double grade in grades)
            {
                minValue = Math.Min(grade, minValue);
            }
            return minValue;
        }
        private double CalcAverageGrade()
        {
            return grades.Sum() / grades.Count;
        }
    }
}