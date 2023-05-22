using System;
using System.Threading;

namespace MainThread
{
    class MainThread
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Main thread");

            Thread thrA = new Thread(ChildThread);
            Thread thrB = new Thread(ChildThread);
            thrA.Start();
            thrB.Start();
        }

        public static void ChildThread()
            => Console.WriteLine("Welcome to the Child thread");

    }
}
