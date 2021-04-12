using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {

        #region Constructors

        public Book(string name)
        {
            _grades = new List<double>();
            _name = name;
        }

        #endregion

        #region Fields

        private List<double> _grades;

        private string _name;

        #endregion

        #region Methods

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Error: Invalid input, {nameof(grade)} is above 100 or lower than 0.");
            }
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                case 'E':
                    AddGrade(50);
                    break;

                case 'F':
                    AddGrade(40);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrades(List<double> grades)
        {
            foreach (double grade in grades)
            {
                AddGrade(grade);
            }
        }

        public Statistics GetStatistics()
        {
            Statistics stats = new Statistics();
            stats.Average = StatisticsHelper.CalcAverage(_grades);
            stats.Highest = StatisticsHelper.CalcMax(_grades);
            stats.Lowest = StatisticsHelper.CalcMin(_grades);
            stats.Letter = StatisticsHelper.CalcGradeLetter(_grades);
            return stats;
        }

        public void ShowStatistics()
        {
            Statistics stats = GetStatistics();
            Console.WriteLine($"The average grade on this grade book is {stats.Average:N2}");
            Console.WriteLine($"The highest grade on this grade book is {stats.Highest}");
            Console.WriteLine($"The lowest grade on this grade book is {stats.Lowest}");
            Console.WriteLine($"The average grade letter on this grade book is {stats.Letter}");
        }

        #endregion

        #region Properties

        public string Name
        {
            set => _name = value;
            get => _name;
        }

        public List<double> Grades
        {
            get => _grades;
        }

        #endregion 
    }
}