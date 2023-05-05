using System;
using System.Threading;

namespace Multithreading
{
    class Multithreading
    {
        public static void Main()
        {
            Thread t = new Thread(WriteY);
            t.Start();
            for (int i = 0; i < 1000; i++) Console.Write("x");
        }

        public static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
