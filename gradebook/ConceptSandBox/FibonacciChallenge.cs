using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptSandBox
{
    class FibonacciChallenge
    {
        public void Run()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            void AddNext(int index)
            {
                fibonacciNumbers.Add(fibonacciNumbers[index - 1] + fibonacciNumbers[index - 2]);
            }

            for (int index = fibonacciNumbers.Count; index < 20; index++)
            {
                AddNext(index);
            }

            {
                int count = 0;
                foreach (int number in fibonacciNumbers)
                {
                    count++;
                    Console.WriteLine($"The index {count} has the number {number}");
                }
            }
        }
    }
}
