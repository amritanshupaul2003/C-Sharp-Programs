using System;

namespace PointerLearn
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            // A pointer stores the memory address of a variable.
            int number = 10;
            int* pointer = &number; // pointer points to number

            Console.WriteLine("Value of number: " + number);
            Console.WriteLine("Address of number: " + (long)pointer);
            Console.WriteLine("Value at pointer: " + *pointer);

            // Changing value through pointer changes original variable too.
            *pointer = 25;
            Console.WriteLine("After update: " + number);
        }
    }
}
