using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public static class StatisticsHelper
    {
        #region Methods
        public static double CalcAverage(List<double> list)
        {
            return list.Sum() / list.Count;
        }

        public static double CalcMin(List<double> list)
        {
            double min = double.MaxValue;

            foreach (double number in list)
            {
                min = Math.Min(min, number);
            }

            return min;
        }

        public static double CalcMax(List<double> list)
        {
            double max = double.MinValue;
            foreach (double number in list)
            {
                max = Math.Max(max, number);
            }
            return max;
        }

        public static char CalcGradeLetter(List<double> list)
        {
            double average = CalcAverage(list);

            switch(average)
            {
                case var grade when grade >= 90.0:
                    return 'A';

                case var grade when grade >= 80.0:
                    return 'B';

                case var grade when grade >= 70.0:
                    return 'C';

                case var grade when grade >= 60.0:
                    return 'D';

                default:
                    return 'F';
            }
        }

        #endregion
    }
} 