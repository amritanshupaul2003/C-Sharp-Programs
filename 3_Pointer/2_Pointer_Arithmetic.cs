using System;

namespace PointerLearn
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            fixed (int* ptr = numbers)
            {
                Console.WriteLine("First value: " + *ptr);
                Console.WriteLine("Second value: " + *(ptr + 1));
                Console.WriteLine("Third value: " + *(ptr + 2));

                // Moving pointer by 1 means moving to next integer slot.
                *(ptr + 3) = 99;
                Console.WriteLine("Updated fourth value: " + numbers[3]);
            }
        }
    }
}
