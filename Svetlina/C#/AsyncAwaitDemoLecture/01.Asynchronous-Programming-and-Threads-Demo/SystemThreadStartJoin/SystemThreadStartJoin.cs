using System;
using System.Threading;

namespace SystemThreadStartJoin
{
    class SystemThreadStartJoin
    {
        static void Main()
        {
            Thread primes = new Thread(() => PrintNumbersInRange(1, 5));
            primes.Start();

            Console.WriteLine("Waiting for thread to finish work...");
            primes.Join();
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
