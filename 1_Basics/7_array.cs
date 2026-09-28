using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declaring and initializing an array
            int[] numbers = { 10, 20, 30, 40, 50 };

            // 2. Accessing array elements
            Console.WriteLine("First element: " + numbers[0]);
            Console.WriteLine("Second element: " + numbers[1]);
            Console.WriteLine("Last element: " + numbers[numbers.Length - 1]);

            // 3. Changing an element
            numbers[2] = 35;
            Console.WriteLine("After update, third element: " + numbers[2]);

            // 4. Looping through an array
            Console.WriteLine("\nAll numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("numbers[" + i + "] = " + numbers[i]);
            }

            // 5. Array of strings
            string[] names = { "Alice", "Bob", "Charlie" };
            Console.WriteLine("\nNames:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            // 6. Multidimensional array
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("\nMatrix:");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
