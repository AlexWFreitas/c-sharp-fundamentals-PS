using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{
    class DiskBook : Book
    {
        #region Constructor

        public DiskBook(string name) : base(name)
        {
        }

        #endregion

        #region Fields and Events

        public override event GradeAddedDelegate GradeAdded;

        readonly string filepath = "F:\\Workspace\\c-sharp-fundamentals-PS\\gradebook\\src\\GradeBook\\";

        #endregion

        #region Methods

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using(StreamWriter writer = File.AppendText($"{filepath}{Name}.txt")) 
                { 
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
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

        public List<double> GenerateGradeList(string filepath)
        {
            List<double> grades = new List<double>();

            using (StreamReader reader = File.OpenText(filepath))
            {
                string[] stringArray = reader.ReadToEnd().Split("\n");

                foreach (string grade in stringArray)
                {
                    if (!String.IsNullOrEmpty(grade))
                    {
                        grades.Add(double.Parse(grade));
                    }

                }
            }
            return grades;
        }

        public override Statistics GetStatistics()
        {
            string filepath = $"{this.filepath}{Name}.txt";
            Statistics stats = new Statistics(GenerateGradeList(filepath));
            return stats;
        }

        public override void ShowStatistics()
        {
            Statistics stats = GetStatistics();
            stats.ShowStatistics(Name);
        }

        #endregion
    }
}
