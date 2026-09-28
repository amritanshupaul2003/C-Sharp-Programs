using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple nested loop for rows and columns
            Console.WriteLine("Example 1: Multiplication table");
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    Console.Write(row * col + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Example 2: Pattern printing
            Console.WriteLine("Example 2: Star pattern");
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Example 3: Matrix-style print
            Console.WriteLine("Example 3: Matrix style output");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("(" + i + "," + j + ") ");
                }
                Console.WriteLine();
            }
        }
    }
}
