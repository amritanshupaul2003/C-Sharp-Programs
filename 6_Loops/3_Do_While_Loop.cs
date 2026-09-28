using System;

namespace LoopLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                Console.WriteLine("i = " + i);
                i++;
            }
            while (i <= 5);
        }
    }
}
