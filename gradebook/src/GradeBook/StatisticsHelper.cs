using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    static class StatisticsHelper
    {
        #region Methods
        public static double CalcAverage(List<double> list)
        {
            return list.Sum() / list.Count;
        }

        public static double CalcMin(List<double> list)
        {
            double min = double.MaxValue;
            foreach(double number in list)
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

        #endregion
    }
}