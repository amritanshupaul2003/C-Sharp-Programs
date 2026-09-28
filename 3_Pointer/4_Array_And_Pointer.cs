using System;

namespace PointerLearn
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5 };

            fixed (int* ptr = values)
            {
                Console.WriteLine("Printing array using pointer:");

                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine("values[" + i + "] = " + *(ptr + i));
                }
            }
        }
    }
}
