using System;

namespace LoopLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 3; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    Console.Write("(" + row + "," + col + ") ");
                }
                Console.WriteLine();
            }
        }
    }
}
