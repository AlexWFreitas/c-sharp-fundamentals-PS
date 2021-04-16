using System;

namespace ConceptSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExecuting Chaining Constructor Test\n");
            ChainingConstructorTest exampleObject = new ChainingConstructorTest("a");

            Console.WriteLine("\nExecuting string list Tests\n");
            new NameList().Run();

            Console.WriteLine("\nExecuting fibonacci Challenge Tests\n");
            new FibonacciChallenge().Run();

        }
    }
}
