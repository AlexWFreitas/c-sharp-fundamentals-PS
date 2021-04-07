using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        List<double> grades;
        string name;
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
                Console.WriteLine("Error Ocurred: Grade is above 100 or lower than 0.");
            }
        }
    }
}