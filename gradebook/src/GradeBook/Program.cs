using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 34.1;
            double y = 27.3;
            double sum = x + y;
            Console.WriteLine(sum);
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
