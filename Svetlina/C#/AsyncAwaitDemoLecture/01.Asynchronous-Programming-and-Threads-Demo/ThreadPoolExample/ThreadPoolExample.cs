using System;
using System.Threading.Tasks;

namespace ThreadPoolExample
{
    class ThreadPoolExample
    {
        static void Main()
        {
            var t1 = new Task(PrintNumbers);
            var t2 = new Task(PrintNumbers);
            t1.Start(); // This will run in a background in the thread pool
            t2.Start(); // This will run in a background in the thread pool
            Console.ReadLine(); // Wait a bit for the tasks to complete 
        }
        static void PrintNumbers()
        {
            for (int i = 0; i < 1000; i++)
                Console.WriteLine(i);
        }
    }
}
