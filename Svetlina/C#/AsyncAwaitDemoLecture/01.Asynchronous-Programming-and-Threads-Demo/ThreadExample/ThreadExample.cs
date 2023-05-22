using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadExample
{
    class ThreadExample
    {
        static void Main(string[] args)
        {
            List<long> numbers = new List<long>();
            Thread t = new Thread(() =>
              SumOddNumbers(numbers, 10, 100000000L));
            t.Start();

            Console.WriteLine("What should I do?");
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "exit") break;
            }

            t.Join();

        } 
        static void SumOddNumbers(List<long> numbers, int a, long b)
        {
            for (int i = a; i < b; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                    Console.WriteLine(i);
                }
            }
        }
    }
}
