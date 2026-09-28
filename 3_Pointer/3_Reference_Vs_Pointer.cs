using System;

namespace PointerLearn
{
    class Person
    {
        public string Name;
    }

    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Value type example:");
            int a = 5;
            int b = a;  // copy of value
            b = 10;
            Console.WriteLine("a = " + a); // remains 5
            Console.WriteLine("b = " + b); // 10

            Console.WriteLine("\nReference type example:");
            Person p1 = new Person();
            p1.Name = "Alice";

            Person p2 = p1; // same object reference
            p2.Name = "Bob";

            Console.WriteLine("p1.Name = " + p1.Name); // Bob
            Console.WriteLine("p2.Name = " + p2.Name); // Bob

            Console.WriteLine("\nPointer example:");
            int x = 7;
            int* ptr = &x;
            Console.WriteLine("x before pointer change: " + x);
            *ptr = 15;
            Console.WriteLine("x after pointer change: " + x);
        }
    }
}
