using System;
using System.Linq;

namespace LINQLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("Even numbers:");
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
