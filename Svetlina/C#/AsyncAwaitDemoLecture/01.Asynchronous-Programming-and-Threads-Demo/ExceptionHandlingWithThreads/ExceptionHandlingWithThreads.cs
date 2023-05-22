using System;
using System.Threading;

namespace ExceptionHandlingWithThreads
{
    class ExceptionHandlingWithThreads
    {
        static void Main()
        {
            try
            {
                new Thread(DoWork).Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }

        }
        public static void DoWork()
        {
            throw new ArgumentNullException();
        }

    }
}
