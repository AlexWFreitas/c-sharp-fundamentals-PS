using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class InMemoryBook : Book
    {
        #region Constructors

        public InMemoryBook(string name) : base(name)
        {
            Grades = new List<double>();
            Name = name;
        }

        #endregion

        #region Fields

        private List<double> _grades;

        private string _name;

        #endregion

        #region Methods

        /// <summary>
        /// Receives a double and adds to a list of grades.
        /// <para>Performs validation so that the number is between 0 and 100.</para>
        /// <br>Throws ArgumentException if validation fails.</br>
        /// <br>Launches an event method on the Class that called it through the delegate instance if there is a method registered.</br>
        /// </summary>
        /// <param name="grade">A double number that represents a grade to add.</param>
        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
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

        // Creates an event that is of delegate type GradeAddedDelegate and can be used to pass methods to other methods.
        public override event GradeAddedDelegate GradeAdded;


        public override Statistics GetStatistics()
        {
            Statistics stats = new Statistics(Grades);
            return stats;
        }

        public override void ShowStatistics()
        {
            Statistics stats = GetStatistics();
            stats.ShowStatistics(Name);
        }

        #endregion

        #region Properties

        public override string Name
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Entered book name is null or empty.");
                }
            }
            get => _name;
        }

        public List<double> Grades
        {
            get => _grades;
            private set => _grades = value;
        }

        #endregion 
    }
}