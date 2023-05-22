using System;

namespace SynchronousCodeLongRunningOperation
{
    class SynchronousCodeLongRunningOperation
    {
        static void Main()
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            PrintNumbersInRange(0, int.MaxValue);
            Console.WriteLine($"Hello, {name}!");
        }
        static void PrintNumbersInRange(int a, int b)
        {
            for (int i = a; i <= b && i > 0; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
