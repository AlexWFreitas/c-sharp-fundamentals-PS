using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Book
    {

        #region Constructors

        public Book(string name)
        {
            _grades = new List<double>();
            this._name = name;
        }

        #endregion

        #region Attributes

        private List<double> _grades;

        private string _name;

        #endregion

        #region Methods

        private double CalcMaxGrade()
        {
            double maxValue = double.MinValue;
            foreach (double grade in _grades)
            {
                maxValue = Math.Max(grade, maxValue);
            }
            return maxValue;
        }

        private double CalcMinGrade()
        {
            double minValue = double.MaxValue;
            foreach (double grade in _grades)
            {
                minValue = Math.Min(grade, minValue);
            }
            return minValue;
        }

        private double CalcAverageGrade()
        {
            return _grades.Sum() / _grades.Count;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Error: Grade {grade} is above 100 or lower than 0.");
            }
        }

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

        #endregion

        #region Properties

        public string Name
        {
            set => _name = value;
            get => _name;
        }

        #endregion 
    }
}