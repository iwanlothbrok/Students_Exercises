using System;
using System.Threading;

namespace ThreadsInCSharp
{
    class ThreadsInCSharp
    {
        static void Main()
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            });

            thread.Start();
        }
    }
}
