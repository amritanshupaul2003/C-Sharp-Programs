using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Basic for loop
            Console.WriteLine("1. Basic for loop");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("i = " + i);
            }

            // 2. for loop counting by 2
            Console.WriteLine("\n2. for loop with step 2");
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine("Even number: " + i);
            }

            // 3. for loop counting down
            Console.WriteLine("\n3. for loop counting down");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Countdown: " + i);
            }

            // 4. for loop with nested loops
            Console.WriteLine("\n4. Nested for loop");
            for (int row = 1; row <= 3; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    Console.Write("(" + row + "," + col + ") ");
                }
                Console.WriteLine();
            }

            // 5. for loop using array
            Console.WriteLine("\n5. for loop with array");
            int[] numbers = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("numbers[" + i + "] = " + numbers[i]);
            }

            // 6. Infinite loop example (commented out to avoid hanging program)
            // for (int i = 1; ; i++)
            // {
            //     Console.WriteLine(i);
            // }
        }
    }
}
