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

            // Do While Loop

            /*
            var index = 0;
            do
            {
                min = Math.Min(min, list[index]);
                index++;
            } while (index < list.Count);
            */

            // While Loop

            var index = 0;
            while (index < list.Count)
            {
                min = Math.Min(min, list[index]);
                index++;
            } 

            // For Loop

            /*
            for (int index = 0; index < list.Count; index++)
            {
                min = Math.Min(min, list[index]);
            }
            */
            

            // For Each Loop

            /* 
            foreach(double number in list)
            {
                min = Math.Min(min, number);
            }
            */


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