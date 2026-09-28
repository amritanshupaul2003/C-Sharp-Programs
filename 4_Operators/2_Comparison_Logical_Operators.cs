using System;

namespace OperatorsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 15;
            bool isAdult = true;
            bool hasID = false;

            Console.WriteLine("x == y: " + (x == y));
            Console.WriteLine("x != y: " + (x != y));
            Console.WriteLine("x < y: " + (x < y));
            Console.WriteLine("x >= y: " + (x >= y));

            Console.WriteLine("isAdult && hasID: " + (isAdult && hasID));
            Console.WriteLine("isAdult || hasID: " + (isAdult || hasID));
            Console.WriteLine("!isAdult: " + (!isAdult));
        }
    }
}
