using System;
using System.Threading;

namespace WatchdogLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A watchdog timer monitors whether a process is alive or responsive.");
            Console.WriteLine("If the system does not refresh the timer in time, a reset or alert happens.");

            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine("System alive, counter: " + counter);
                counter++;
                Thread.Sleep(500);
            }

            Console.WriteLine("Watchdog timeout would trigger if the system stopped heartbeating.");
        }
    }
}
