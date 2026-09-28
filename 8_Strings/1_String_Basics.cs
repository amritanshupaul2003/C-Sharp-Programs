using System;

namespace StringLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Alice";
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Length: " + name.Length);
            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Lowercase: " + name.ToLower());
        }
    }
}
