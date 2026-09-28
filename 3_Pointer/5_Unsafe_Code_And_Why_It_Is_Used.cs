using System;

namespace PointerLearn
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Pointers are used in unsafe code.");
            Console.WriteLine("They allow direct memory access, which is powerful but risky.");

            int value = 100;
            int* ptr = &value;

            Console.WriteLine("Before change: " + value);
            *ptr = 250;
            Console.WriteLine("After change: " + value);

            Console.WriteLine("\nImportant:");
            Console.WriteLine("- Use pointers only when necessary.");
            Console.WriteLine("- They can cause memory errors if used incorrectly.");
            Console.WriteLine("- In normal C# programming, references are safer and easier.");
        }
    }
}
