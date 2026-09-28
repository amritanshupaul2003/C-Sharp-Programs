using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            int marks = 75;

            // Simple if statement
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }

            // if-else statement
            if (marks >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // if-else-if ladder
            if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // Example with strings
            string name = "Alice";
            if (name == "Alice")
            {
                Console.WriteLine("Hello Alice!");
            }
            else
            {
                Console.WriteLine("Who are you?");
            }

            // Example with boolean
            bool isStudent = true;
            if (isStudent == true)
            {
                Console.WriteLine("You are a student.");
            }
            else
            {
                Console.WriteLine("You are not a student.");
            }
        }
    }
}
