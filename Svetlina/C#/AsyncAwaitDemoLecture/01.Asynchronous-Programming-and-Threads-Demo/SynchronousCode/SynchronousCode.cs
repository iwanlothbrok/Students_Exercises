using System;

namespace SynchronousCode
{
    class SynchronousCode
    {
        static void Main()
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            PrintNumbersInRange(0, 100);
            Console.WriteLine($"Hello, {name}!");
        }

        static void PrintNumbersInRange(int a, int b)
        {
            for (int i = a; i <= b && i > 0; i++)
                Console.WriteLine(i);
        }

    }
}
