using System;
using System.Threading.Tasks;

namespace AsynchronousCode
{
    class AsynchronousCode
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintNumbersInRange(0, n);
            var task = Task.Run(() =>
                PrintNumbersInRange(n, n * n));

            Console.WriteLine("Done.");
            task.Wait();
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
