using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer types
            byte ageInDays = 30;                 // 0 to 255
            short smallNumber = -200;            // -32,768 to 32,767
            int totalStudents = 1200;            // Common integer type
            long bigNumber = 1234567890123L;     // Large integer

            // Floating-point types
            float piFloat = 3.14f;               // Single precision float
            double piDouble = 3.14159265359;     // Double precision float
            decimal money = 99.99m;             // Used for money and precise values

            // Character and string types
            char grade = 'A';                    // Single character
            string name = "Alice";              // Text value

            // Boolean type
            bool isStudent = true;               // true or false

            // Other useful examples
            int x = 10;
            int y = 20;
            int sum = x + y;

            // Printing values
            Console.WriteLine("--- Data Types in C# ---");
            Console.WriteLine("byte: " + ageInDays);
            Console.WriteLine("short: " + smallNumber);
            Console.WriteLine("int: " + totalStudents);
            Console.WriteLine("long: " + bigNumber);
            Console.WriteLine("float: " + piFloat);
            Console.WriteLine("double: " + piDouble);
            Console.WriteLine("decimal: " + money);
            Console.WriteLine("char: " + grade);
            Console.WriteLine("string: " + name);
            Console.WriteLine("bool: " + isStudent);
            Console.WriteLine("sum: " + sum);

            // Example of assignment and arithmetic
            int a = 5;
            int b = 3;
            int result = a * b;
            Console.WriteLine("a * b = " + result);
        }
    }
}
